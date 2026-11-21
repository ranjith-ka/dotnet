# .NET tutorials

| Tutorial | For | Path |
|----------|-----|------|
| **C# Basics and OOP for DevOps** | Syntax, classes, objects, constructors, state, and encapsulation | [DOTNET_CSHARP_OOP_BASICS.md](./DOTNET_CSHARP_OOP_BASICS.md) |
| **Kubernetes MCP application** | Separate API, C# client, tools, and tests | [Application guide](../../projects/kubernetes-mcp/README.md) |

The OOP tutorial has four local teaching skills:

1. `$dotnet-oop-foundations`
2. `$dotnet-oop-classes`
3. `$dotnet-oop-encapsulation`
4. `$dotnet-oop-lab`

Use [the learning tracks guide](./LEARNING_TRACKS.md) for the current lesson pace,
source files, and commands. Stay in foundations while learning syntax. Use
`$dotnet-kubernetes-mcp` when choosing to apply those concepts to the MCP project.

For classes and objects, use the saved
[checkpoints and revision notes](./progress/dotnet-oop-classes.md) to see where
to resume or what to revise. Invoke `$dotnet-oop-classes` with a checkpoint number
and a 15-, 30-, or 45-minute session length.

## Two learning tracks

| Track | Open this solution | Start here | Run |
|-------|--------------------|------------|-----|
| C# foundations | [CSharpFoundations.slnx](./CSharpFoundations.slnx) | [Small console example](./practice/02-operators/Program.cs) | `make basics` |
| Kubernetes MCP application | [KubernetesMcp.slnx](../../projects/kubernetes-mcp/KubernetesMcp.slnx) | [API and client guide](../../projects/kubernetes-mcp/README.md) | `make mcp`, then `make pods-http` in another terminal |

Focus on the foundations solution while learning variables, comparisons, methods,
parameters, arguments, return values, and then classes and objects. It has no MCP
dependencies or cluster requirements. Its current example calls `HasEnoughPods`.

From the repository root:

```bash
make basics       # Foundations tests, then console output (alias: make run)
make test-basics   # Only foundations tests (alias: make test)
make pods         # Separate MCP track: start a stdio server and print pods
make test-mcp     # Separate MCP track: verify real tool calls against kind
```

The longer commands `make dotnet-operators` and `make dotnet-operators-test`
remain aliases for the foundations track. Node.js is needed only for the optional
`make inspect` command.

The SDK configuration accepts later .NET 10 feature bands, including 10.0.301.
