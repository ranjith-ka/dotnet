# C# foundations practice

Open [CSharpFoundations.slnx](../../CSharpFoundations.slnx) for this learning track.
It contains only the beginner console program and its deployment-logic tests.

## Small lesson files

| File | Topic |
|---|---|
| [Program.cs](./Program.cs) | Calls that run the lessons in order |
| [BasicsMethods.cs](./BasicsMethods.cs) | Method arguments, comparisons, and return values |
| [C1C2ClassesAndObjects.cs](./C1C2ClassesAndObjects.cs) | Class, object, properties, and behavior |
| [C3Constructors.cs](./C3Constructors.cs) | Constructor arguments and property assignment |
| [C4InstanceAndStatic.cs](./C4InstanceAndStatic.cs) | Instance and static method calls |
| [C5SharedReferences.cs](./C5SharedReferences.cs) | Shared references versus separate objects |
| [KubernetesDeployment.cs](./KubernetesDeployment.cs) | Shared class, properties, one-parameter constructor, and PrintStatus |

Each lesson has a static `Run()` method called by `Program.cs`. Its variables
belong to that method, so you can read each lesson independently.

The class has one constructor: `KubernetesDeployment(int replicas)`.
It assigns the parameter to `Replicas`. All lessons use this version;
the earlier missing-assignment demonstration has been removed.

Follow [the learning tracks guide](../../LEARNING_TRACKS.md) and start with
`$dotnet-oop-foundations`. Introduce one concept at a time, predict the output,
and explain the value flow before moving to the next lesson.

Start with `BasicsMethods.cs` and `DeploymentLogic.HasEnoughPods`:

```csharp
int runningPods = 3;
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
