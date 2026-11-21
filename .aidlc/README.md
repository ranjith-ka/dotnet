# AI-DLC learning workspace

Learn C# fundamentals and AI-driven software development through small changes to
the existing tutorial. You choose the behavior, review the reasoning, and explain
the result; AI helps clarify requirements, propose changes, and verify them.

This folder contains a local teaching adaptation of AI-DLC. Creating it does not
install the official workflow runtime or enable an `$aidlc` command. The prompts
can be pasted into your existing coding conversation.

## Start here

First read [the learning tracks guide](../tutorials/dotnet/LEARNING_TRACKS.md).
Use [CSharpFoundations.slnx](../tutorials/dotnet/CSharpFoundations.slnx) while
learning syntax and OOP. The separate
[Kubernetes MCP solution](../projects/kubernetes-mcp/KubernetesMcp.slnx) contains
the real API, client, and tool tests. The numbered prompts below begin with
foundations; prompt 9 in the prompt guide switches to MCP when you choose it.

1. Open [the example prompts](./PROMPTS.md) and use **1. Read the existing code**.
2. Predict the result and explain the code in your own words.
3. Use **2. Define the improvement** with the
   [configurable pod-count exercise](./exercises/01-configurable-pod-count.md).
4. Resolve the open requirement and review the acceptance examples.
5. Request implementation when you are ready, then review and run it.

Start with variables, comparisons, methods, parameters, and return values. Introduce
classes, interfaces, dependency injection, and advanced topics as later exercises.

For the MCP application track, use `$dotnet-kubernetes-mcp` and its
[application guide](../projects/kubernetes-mcp/README.md). Choose that track when
ready to apply the foundations concepts. Keep its API, client, and tests in the
separate MCP solution.

## How the phases map to this project

| Phase | Learning activity | Evidence |
|---|---|---|
| Initialization | Inspect the current program and tests | Explanation of existing behavior |
| Ideation | Choose one useful improvement | A short problem statement |
| Inception | Define behavior and resolve ambiguity | Requirements and acceptance examples |
| Construction | Design, implement, and test a small change | Reviewed diff and test results |
| Operation | Run the program and inspect the output | Observed behavior and remaining limitations |

For this console exercise, Operation means local execution and inspection. A later
service exercise can add deployment, monitoring, and recovery.

## Working agreement

- Keep lessons focused on one small change that you can explain.
- Introduce one concept at a time; explain identifiers, keywords, and punctuation.
- Ask one prediction question, wait for the learner, and then correct the reasoning.
- Start with code reading, prediction, and requirement clarification.
- Show explanations and proposed code in chat during those learning steps.
- Edit application code when implementation is requested.
- Correct both programming misunderstandings and ambiguous prompts.
- State what was actually checked; distinguish expected output from observed output.
- Record unresolved requirements explicitly instead of silently choosing behavior.
- Use current official documentation when teaching version-specific .NET 10 features.

The exercise starts with proposed requirements. It is not an implementation order.
Once decisions are made, update its decision record and verification evidence.

## Commands

From the repository root:

```bash
make basics       # Foundations: tests, then the small console example
make test-basics  # Foundations: tests only
make mcp          # Application: start the HTTP MCP server
make pods-http    # Application: call that API from another terminal
make pods         # Application: start a stdio server/client and print pod lists
make test-mcp     # Application: real MCP integration assertions against kind-k8s
```

`make run` and `make test` remain foundations aliases. `make test-mcp-unit` runs
validation tests without a cluster. Test commands report assertions; `make pods`
and `make pods-http` display the pod lists. Node.js is needed only for optional
`make inspect`; no AI model is required to call the tools.

## Official references

- [AWS AI-DLC methodology](https://aws.amazon.com/blogs/devops/ai-driven-development-life-cycle/)
- [AI-DLC Workflows guide](https://awslabs.github.io/aidlc-workflows/guide/00-introduction/)
- [AI-DLC Workflows repository](https://github.com/awslabs/aidlc-workflows)

The original methodology describes Inception, Construction, and Operations. The
current workflow guide also describes Initialization and Ideation. Consult the
documentation for your installed release when using the official runtime.
