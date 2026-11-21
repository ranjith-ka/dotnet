using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;
using KubernetesMcp.Api;
using System.Text.Json;

using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(90));

try
{
    // Default: start the server ourselves. --http connects to the running API.
    IClientTransport transport = args.Contains("--http")
        ? new HttpClientTransport(new HttpClientTransportOptions
        {
            Endpoint = new Uri("http://localhost:5080/mcp")
        })
        : new StdioClientTransport(new StdioClientTransportOptions
        {
            Name = "Local Kubernetes tools",
            Command = "dotnet",
            Arguments = [typeof(KubernetesTools).Assembly.Location, "--stdio"]
        });
    await using var client = await McpClient.CreateAsync(
        transport, cancellationToken: timeout.Token);

    foreach (string namespaceName in new[] { "default", "kube-system" })
    {
        var result = await client.CallToolAsync("get_pods",
            new Dictionary<string, object?> { ["namespaceName"] = namespaceName },
            cancellationToken: timeout.Token);

        string json = string.Join(Environment.NewLine,
            result.Content.OfType<TextContentBlock>().Select(block => block.Text));
        if (result.IsError == true)
        {
            throw new InvalidOperationException($"get_pods failed for {namespaceName}: {json}");
        }

        using var document = JsonDocument.Parse(json);
        var pods = document.RootElement.GetProperty("items");

        Console.WriteLine($"Namespace: {namespaceName}");
        if (pods.GetArrayLength() == 0)
        {
            Console.WriteLine("No pods found.");
        }
        else
        {
            Console.WriteLine($"{"NAME",-65} PHASE");
            foreach (var pod in pods.EnumerateArray())
            {
                string? name = pod.GetProperty("metadata").GetProperty("name").GetString();
                string? phase = pod.GetProperty("status").GetProperty("phase").GetString();
                Console.WriteLine($"{name,-65} {phase}");
            }
        }
        Console.WriteLine();
    }
}
catch (Exception exception)
{
    Console.Error.WriteLine($"Unable to list pods: {exception.Message}");
    Environment.ExitCode = 1;
}
