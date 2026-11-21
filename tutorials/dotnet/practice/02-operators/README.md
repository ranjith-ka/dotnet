# C# foundations practice

Open [CSharpFoundations.slnx](../../CSharpFoundations.slnx) for this learning track.
It contains only the beginner console program and its deployment-logic tests.

Follow [the learning tracks guide](../../LEARNING_TRACKS.md) and start with
`$dotnet-oop-foundations`. Introduce one concept at a time, predict the output,
and explain the value flow before moving to the next lesson.

Start with `Program.cs` and `DeploymentLogic.HasEnoughPods`:

```csharp
int runningPods = 2;
bool hasEnoughPods = DeploymentLogic.HasEnoughPods(runningPods);
```

Follow the number into the method parameter, evaluate `runningPods >= 3`, and
follow the returned Boolean into `hasEnoughPods`. Predict the output before running.

From the repository root:

```sh
make basics       # Tests first, then runs the small console example
make test-basics   # Only foundations tests
```

`make run` and `make test` are aliases for the foundations commands. No Kubernetes,
MCP, Node.js, or external services are required for this track.

The separate [Kubernetes MCP solution](../../../../projects/kubernetes-mcp/README.md)
contains the API, MCP tools, C# client, and cluster integration tests.
