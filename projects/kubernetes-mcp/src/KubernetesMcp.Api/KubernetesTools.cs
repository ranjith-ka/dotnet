using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using ModelContextProtocol.Server;

namespace KubernetesMcp.Api;

[McpServerToolType]
public class KubernetesTools
{
    public string Context { get; }

    public KubernetesTools(string context)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(context);
        Context = context;
    }

    [McpServerTool(Name = "get_pods")]
    [Description("List pods in one namespace of the configured Kubernetes context. Returns a Kubernetes PodList as JSON.")]
    public async Task<string> GetPods(
        [Description("Kubernetes namespace, for example default or kube-system.")] string namespaceName,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(namespaceName) || namespaceName.Length > 63 ||
            !Regex.IsMatch(namespaceName, "^[a-z0-9]([-a-z0-9]*[a-z0-9])?$"))
        {
            throw new ArgumentException("Supply a valid Kubernetes namespace name.", nameof(namespaceName));
        }

        // Separate arguments avoid executing command text through a shell.
        var startInfo = new ProcessStartInfo("kubectl")
        {
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true
        };
        foreach (string argument in new[]
        {
            "--context", Context, "get", "pods", "--namespace", namespaceName,
            "--output", "json", "--request-timeout=20s"
        })
        {
            startInfo.ArgumentList.Add(argument);
        }

        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        timeout.CancelAfter(TimeSpan.FromSeconds(30));
        using var process = new Process { StartInfo = startInfo };
        process.Start();
        Task<string> output = process.StandardOutput.ReadToEndAsync();
        Task<string> error = process.StandardError.ReadToEndAsync();
        try
        {
            await process.WaitForExitAsync(timeout.Token);
        }
        catch (OperationCanceledException)
        {
            if (!process.HasExited)
            {
                process.Kill(entireProcessTree: true);
            }
            await process.WaitForExitAsync();
            await Task.WhenAll(output, error);
            throw;
        }

        string stderr = await error;
        string stdout = await output;
        if (process.ExitCode != 0)
        {
            throw new InvalidOperationException($"kubectl failed: {stderr.Trim()}");
        }

        return stdout;
    }
}
