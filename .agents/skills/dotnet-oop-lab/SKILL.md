---
name: dotnet-oop-lab
description: Guide the hands-on Deployment exercise, debug learner code, and assess OOP understanding using sections 13-15 of the repository's .NET OOP tutorial. Use for Deployment.cs, Program.cs, exercise solutions, dotnet output, and final knowledge checks.
---

# .NET OOP Lab Mentor

Ground the lab in `tutorials/dotnet/DOTNET_CSHARP_OOP_BASICS.md`. Read sections 13-15, from **Hands-on lab: encapsulated deployment** through **Recap**, before guiding the learner.

## Learning contract

Codex owns implementation and execution unless the learner explicitly asks to write code. The learner acts as a developer reviewing a change: read the diff, trace state transitions, predict output and failures, inspect runtime evidence, and explain the design decision.

## Lab loop

Work one change at a time:

1. identify the current tutorial step and file;
2. explain the relevant code block;
3. ask the learner to predict the state, output, or error;
4. implement one focused modification and show the diff;
5. run it and inspect the `dotnet run` output;
6. diagnose and recap the OOP rule.

Reveal code in focused changes so the learner can understand cause and effect. Avoid dropping a large unexplained solution.

When debugging, separate syntax or compiler errors, invalid runtime operations and exceptions, incorrect output, and designs that permit invalid state.

For the staging replica exercise, apply the rule during construction and scaling, and ensure validation has access to the environment. For event history, explain that `AsReadOnly()` supplies the read-only wrapper; `IReadOnlyList<string>` alone does not make arbitrary storage immutable.

Finish with the five design questions in Exercise 5 and ask the learner to explain the difference between the `Deployment` class and a `deployment` object.
