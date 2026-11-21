# Example learning prompts

Paste one prompt at a time. Adjust its behavior examples to match your intent.
These prompts guide a conversation; they do not automatically execute a workflow.

See [the two learning tracks](../tutorials/dotnet/LEARNING_TRACKS.md).
Prompts 1–6 use `tutorials/dotnet/CSharpFoundations.slnx`; prompts 7–8 can be
applied to either chosen track. Use prompt 9 to enter the separate MCP application.
Introduce one concept per lesson when syntax feels overwhelming.

## 1. Read the existing code — Initialization

```text
I am learning C# foundations through this repository.
Use $dotnet-oop-foundations and tutorials/dotnet/CSharpFoundations.slnx.

Read these files:
- tutorials/dotnet/practice/02-operators/Program.cs
- tutorials/dotnet/practice/02-operators/BasicsMethods.cs
- tutorials/dotnet/practice/02-operators/DeploymentLogic.cs
- tutorials/dotnet/practice/02-operators.Tests/DeploymentLogicTests.cs

Start with HasEnoughPods and its call in BasicsMethods.cs. Explain the goal, method
declaration, parameter, argument, comparison, return value, and receiving variable.
Trace how the value moves through the code. Explain unfamiliar syntax simply.

Give me one output-prediction question before revealing its answer. Correct my
explanation when I respond. Explain identifiers, keywords, and punctuation one
small block at a time. Keep this lesson in chat without editing files or adding
MCP framework code.
```

## 2. Define the improvement — Ideation and Inception

```text
Use .aidlc/exercises/01-configurable-pod-count.md as our first AI-DLC exercise.

I want callers to choose the required pod count instead of fixing it at 3.
Explain the problem and propose precise requirements and acceptance examples.
Separate existing behavior, proposed behavior, and unresolved decisions.

Ask me to decide what should happen with negative counts. Explain the tradeoffs
in beginner language. Do not treat the proposal as an approved requirement.
Keep this step in chat without changing application code.
```

## 3. Review the design — Construction planning

```text
Using the requirements we have agreed in this conversation, propose the smallest
change for the configurable pod-count exercise. If a required decision is still
missing, identify it before designing behavior that depends on it.

Show the proposed method signature and one call site in chat. Explain parameters
versus arguments and how >= determines the result. Identify which existing call
sites and tests will need updating. Explain any compatibility choice.

Ask me to trace one example through the proposed code. Do not edit files yet.
```

## 4. Implement the agreed change — Construction

```text
Implement the configurable pod-count behavior using the requirements we agreed.
If the invalid-input behavior remains unresolved, ask for that decision first.

Update DeploymentLogic, its callers, and relevant tests. Keep the solution focused
on methods, parameters, and comparisons. Add tests for below, equal to, and above
the required count, plus the agreed zero and negative-input behavior.

Run make test-basics. Show the focused diff and explain the execution path. Report the
actual results and any environmental blockers. Record the agreed requirements
and verification evidence in the exercise file, distinguishing new results from
the original baseline.
```

## 5. Review the result — Construction verification

```text
Review our configurable pod-count change against its agreed acceptance criteria.

Check the implementation, callers, and tests for missing behavior, boundary
errors, and unnecessary complexity. Identify any test that could pass while the
requirement is still broken. Explain the most important findings first.

Keep this as a review without editing files. Ask me to explain why equal running
and required counts should return true.
```

## 6. Run and observe — Operation

```text
Run make basics for the foundations exercise. Explain that it runs tests before the
application, then connect each printed value to the inputs and relevant method.

Distinguish successful execution, failed tests, compiler errors, and environment
or package-source problems. Report observed output separately from predictions.
Do not change business logic just to obtain successful execution.

End with one question about the output that checks my understanding.
```

## 7. Improve my prompt — Use throughout

```text
Help me improve the following programming request:

[Paste my request here.]

Identify the goal, relevant code, expected behavior, examples, constraints,
unresolved decisions, and verification steps. Explain which missing details
could materially change the implementation. Preserve my intended scope.

Return a clearer prompt and briefly explain why the changes help. Do not invent
requirements or implement the request in this step.
```

## 8. Introduce a .NET 10 feature — Later lessons

```text
Using the current code we are discussing, identify one relevant .NET 10 or C# 14
feature. Verify its availability and behavior in current official documentation.

Explain the prerequisite concepts, show a small before-and-after example in chat,
and distinguish a language feature from a runtime or library feature. Explain
whether adopting it improves this specific code and any compatibility tradeoffs.

If the current code has no useful application for it, say so. Do not change files.
```

## 9. Enter the MCP application track — When ready

```text
Use $dotnet-kubernetes-mcp and projects/kubernetes-mcp/KubernetesMcp.slnx.
Read tutorials/dotnet/LEARNING_TRACKS.md and projects/kubernetes-mcp/README.md.

Start with src/KubernetesMcp.Api/KubernetesTools.cs under that project directory.
Explain only the class name, Context property, and constructor first. Trace
"kind-k8s" into the object's state. Explain each unfamiliar identifier and token.
Ask one prediction question and wait for my answer before introducing the next
concept. Correct my reasoning when I respond.

As we progress, trace the namespace argument into GetPods, then introduce the
MCP attribute, async method, kubectl call, and JSON separately. Explain the API,
client, and tests in separate lessons. Keep this lesson in chat without editing.

For a later feature, use AI-DLC to agree requirements and acceptance examples
before designing or implementing it. Keep MCP code in its own solution and
use the foundations solution when I need basic syntax practice.
```
