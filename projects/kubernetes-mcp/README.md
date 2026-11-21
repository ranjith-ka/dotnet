# Kubernetes MCP application track

Open `KubernetesMcp.slnx`. This solution is independent of the
[C# foundations solution](../../tutorials/dotnet/CSharpFoundations.slnx).

See [the learning tracks guide](../../tutorials/dotnet/LEARNING_TRACKS.md) for the
lesson sequence. Use `$dotnet-kubernetes-mcp` for this application; the four
`dotnet-oop` skills teach small examples in the separate foundations solution.
Learn one concept at a time and return to foundations when syntax needs practice.
For AI-DLC learning prompts, see [the local prompt guide](../../.aidlc/PROMPTS.md).

```text
src/KubernetesMcp.Api/       ASP.NET Core MCP server and KubernetesTools class
src/KubernetesMcp.Client/    C# client that prints the returned pod lists
tests/KubernetesMcp.Tests/   Tool validation and MCP integration tests
```

## Run locally

From the repository root, start the API:

```sh
make mcp
```

In another terminal, call `get_pods` over HTTP for `default` and then `kube-system`:

```sh
make pods-http
```

The MCP endpoint is `http://localhost:5080/mcp`. It speaks the MCP protocol;
the C# client handles initialization and tool calls. This is a local development
endpoint without authentication and binds to localhost through `make mcp`.

For the original one-command experience, `make pods` starts its own server using
stdio, calls the same tool twice, prints the results, and exits. No Node.js,
browser, or AI model is needed. `make inspect` remains an optional npm-based UI.

The tool requires `kubectl` on PATH and local kubeconfig access to `kind-k8s`.
It returns a Kubernetes list as JSON; an empty `items` array means no pods.
The client prints pod names and phases, or `No pods found.`.

## Tests and builds

```sh
make test-mcp-unit  # Validation tests; cluster integration test is skipped
make test-mcp       # Also calls the real MCP server for default, then kube-system
dotnet build projects/kubernetes-mcp/KubernetesMcp.slnx
```

The cluster integration test uses stdio and expects kind system pods. The HTTP
flow can be checked with `make mcp` and `make pods-http`. Tests report assertions;
use the client commands to display the pod list.

`KubernetesTools` stores the context in its constructor and accepts a namespace
on each `GetPods` call. It runs kubectl with separate arguments, a timeout, and
cancellation. MCP exposes that method as `get_pods`.

The default context is `kind-k8s`. Override it using the environment variable
`Kubernetes__Context`. This remains a local development app: in-cluster service
account authentication, RBAC manifests, and container deployment are later work.

The server follows the official [MCP C# SDK HTTP and stdio patterns](https://github.com/modelcontextprotocol/csharp-sdk/blob/main/docs/concepts/getting-started.md).
