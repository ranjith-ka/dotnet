# Exercise 1: Configurable required pod count

Status: proposed; application code has not been changed for this exercise.

## Learning goal

Understand method parameters, call-site arguments, integer comparisons, Boolean
return values, and acceptance criteria. Practise explaining a requirement before
asking AI to implement it.

## Initialization: current behavior

Track: [C# foundations](../../tutorials/dotnet/CSharpFoundations.slnx).
This exercise compares supplied numbers; it does not query Kubernetes or change
the separate MCP tool.

Sources: [DeploymentLogic.cs](../../tutorials/dotnet/practice/02-operators/DeploymentLogic.cs),
[BasicsMethods.cs](../../tutorials/dotnet/practice/02-operators/BasicsMethods.cs), and
[DeploymentLogicTests.cs](../../tutorials/dotnet/practice/02-operators.Tests/DeploymentLogicTests.cs).

```csharp
public static bool HasEnoughPods(int runningPods)
{
    return runningPods >= 3;
}
```

The method compares running pods with a fixed threshold of 3. BasicsMethods.cs supplies
3 running pods, so the current method returns true. The existing tests directly
cover HasEnoughPods with 2, 3, and 4 running pods, as well as total-pod calculation,
deployment success, and attention conditions. Re-read the source before starting
the exercise if it has changed.

## Ideation: desired improvement

Allow callers to supply the required pod count so different deployments can use
different thresholds.

## Inception: proposed requirements

- Receive the running count and required count as integer inputs.
- For valid counts, return true when running is greater than or equal to required.
- Return false when running is below required.
- Preserve the current example's result (true for 3 running pods) by supplying
  a required count of 3.
- Keep the other deployment calculations unchanged.

### Proposed acceptance examples

| Running | Required | Expected |
|---:|---:|---|
| 2 | 3 | false |
| 3 | 3 | true |
| 5 | 4 | true |
| 0 | 3 | false |
| 0 | 0 | true, if a zero requirement is allowed |
| -1 | 3 | Unresolved: reject or compare directly? |
| 3 | -1 | Unresolved: reject or compare directly? |

### Decisions to make

1. Are negative counts invalid? If so, how should the method signal that?
2. Is a required count of zero valid?
3. Should callers always pass both arguments, or should a default preserve the old call form?

## Construction: proposed scope

- Update the method and affected callers according to the agreed decisions.
- Extend the existing HasEnoughPods tests in DeploymentLogicTests.cs to cover
  configurable thresholds and agreed invalid-input behavior.
- Verify the behavior using make test-basics and inspect the focused diff.

No interfaces, dependency injection, or infrastructure changes are needed for
this exercise. Those concepts belong in later lessons with suitable requirements.

## Operation: local verification

Run make basics after implementation. Confirm the tests pass and the example's
"Has enough pods" output remains True for 3 running and 3 required pods.
Use a test to verify equality returns true when both counts are 3.

## Decision record

Pending learner decisions. No requirements have been approved for implementation.

## Verification evidence

Not run for this exercise. Record commands and actual results after implementation.

## Explain it back

- Which names are parameters, and which values are arguments?
- Why does equality satisfy the required count?
- Which test would detect accidentally replacing >= with >?
- What behavior did we choose for zero and negative counts, and why?
