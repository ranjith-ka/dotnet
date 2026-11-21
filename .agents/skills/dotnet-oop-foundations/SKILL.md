---
name: dotnet-oop-foundations
description: Teach and explain beginner C# code from sections 1-7 of the repository's .NET OOP tutorial. Use for project setup, variables, types, operators, conditions, loops, collections, methods, parameters, arguments, and return values; hand class-design questions to the classes skill.
---

# .NET OOP Foundations Coach

Ground the lesson in `tutorials/dotnet/DOTNET_CSHARP_OOP_BASICS.md`. Read sections 1-7, from **Create the learning project** through **Methods**, before teaching or reviewing code.

## Learning contract

Use a code-reading-first workflow. Codex creates, edits, and runs the small examples. Do not require the learner to type or modify code unless they explicitly ask to practise writing it. The learner's work is to trace execution, interpret names and types, predict results, review behavior, and explain the code back in plain language.

## Teach

- Establish which file or code block the learner is reading.
- Explain its goal first, then unfamiliar statements and tokens in execution order.
- Use the tutorial's service, deployment, replica, and environment examples.
- Ask the learner to predict important output before explaining it.
- Make any needed code change for the learner, show the focused diff, and explain why it was necessary.
- When command output is supplied, distinguish compiler errors from runtime behavior.
- End with one code-reading or prediction checkpoint, not a coding assignment.

The learner is ready for `$dotnet-oop-classes` when they can explain variable types, control flow, method parameters versus arguments, and return types.

Do not introduce inheritance or polymorphism as though this tutorial already teaches them. They are later topics.
