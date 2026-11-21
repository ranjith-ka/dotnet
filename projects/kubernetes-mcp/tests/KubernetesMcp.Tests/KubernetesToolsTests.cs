using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;
using KubernetesMcp.Api;
using System.Text.Json;
using Xunit;

public class KubernetesToolsTests
{
    public static bool ClusterTestsEnabled => Environment.GetEnvironmentVariable("RUN_K8S_TESTS") == "1";

    [Theory]
    [InlineData("")]
    [InlineData("--all-namespaces")]
    [InlineData("default; echo unsafe")]
    [InlineData("UPPERCASE")]
    public async Task GetPods_RejectsInvalidNamespace(string namespaceName)
    {
        var tools = new KubernetesTools("kind-k8s");

        await Assert.ThrowsAsync<ArgumentException>(() => tools.GetPods(namespaceName, TestContext.Current.CancellationToken));
    }

    [Fact(Skip = "Run make test-mcp to enable the local kind integration test.", SkipUnless = nameof(ClusterTestsEnabled))]
    public async Task McpTool_ListsDefaultThenKubeSystemPods()
    {
        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(TestContext.Current.CancellationToken);
        timeout.CancelAfter(TimeSpan.FromSeconds(90));
        await using var client = await McpClient.CreateAsync(
            new StdioClientTransport(new StdioClientTransportOptions
            {
                Name = "Local Kubernetes tools",
                Command = "dotnet",
                Arguments = [typeof(KubernetesTools).Assembly.Location, "--stdio"]
            }), cancellationToken: timeout.Token);

        var tools = await client.ListToolsAsync(cancellationToken: timeout.Token);
        Assert.Contains(tools, tool => tool.Name == "get_pods");

        // Calls are sequential: default completes before kube-system starts.
        foreach (string namespaceName in new[] { "default", "kube-system" })
        {
            var result = await client.CallToolAsync("get_pods",
                new Dictionary<string, object?> { ["namespaceName"] = namespaceName },
                cancellationToken: timeout.Token);

            Assert.False(result.IsError == true,
                string.Join(Environment.NewLine, result.Content.OfType<TextContentBlock>().Select(block => block.Text)));
            string json = Assert.Single(result.Content.OfType<TextContentBlock>()).Text;
            using var document = JsonDocument.Parse(json);
            Assert.Equal("List", document.RootElement.GetProperty("kind").GetString());
            var pods = document.RootElement.GetProperty("items");
            foreach (var pod in pods.EnumerateArray())
            {
                Assert.Equal("Pod", pod.GetProperty("kind").GetString());
                Assert.Equal(namespaceName, pod.GetProperty("metadata").GetProperty("namespace").GetString());
            }
            if (namespaceName == "kube-system")
            {
                Assert.True(pods.GetArrayLength() > 0, "Expected kind system pods.");
            }
        }
    }
}
