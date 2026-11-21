using KubernetesMcp.Api;

// Keep stdio available for the self-contained client and integration tests.
if (args.Contains("--stdio"))
{
    var builder = Host.CreateApplicationBuilder(args.Where(arg => arg != "--stdio").ToArray());
    builder.Logging.AddConsole(options => options.LogToStandardErrorThreshold = LogLevel.Trace);
    var tools = new KubernetesTools(builder.Configuration["Kubernetes:Context"] ?? "kind-k8s");
    builder.Services.AddMcpServer().WithStdioServerTransport().WithTools(tools);
    await builder.Build().RunAsync();
}
else
{
    var builder = WebApplication.CreateBuilder(args);
    var tools = new KubernetesTools(builder.Configuration["Kubernetes:Context"] ?? "kind-k8s");
    builder.Services.AddMcpServer().WithHttpTransport().WithTools(tools);

    var app = builder.Build();
    app.MapMcp("/mcp");
    await app.RunAsync();
}
