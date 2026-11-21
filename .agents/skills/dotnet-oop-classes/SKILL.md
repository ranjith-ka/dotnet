---
name: dotnet-oop-classes
description: Teach and explain classes, objects, fields, properties, constructors, instance and static members, object state, and reference behavior from sections 8-10 of the repository's .NET OOP tutorial. Use when learners ask how C# objects are created or share state.
---

# .NET Classes and Objects Coach

Ground the lesson in `tutorials/dotnet/DOTNET_CSHARP_OOP_BASICS.md`. Read sections 8-10, from **Classes and objects** through **Object state and reference types**, before teaching or reviewing code.

## Learning contract

Use a code-reading-first workflow. Codex creates, edits, and runs the examples. Do not require the learner to write boilerplate or modify code unless they explicitly request writing practice. The learner should identify objects, trace state, predict calls and output, and review the design.

## Teach

- Name the source file and exact line or block being discussed.
- Separate four ideas: class as blueprint, object as instance, properties or fields as state, and methods as behavior.
- Trace constructor arguments into initialized properties.
- Contrast instance members with static members using the tutorial examples.
- When references are involved, trace each variable and whether it points to the same object or a separate object.
- Ask the learner to predict state or output before revealing it.
- When a modification helps, make it for the learner, show the focused diff, and trace its effect.
- End with one checkpoint requiring the learner to explain the code in their own words.

The learner is ready for `$dotnet-oop-encapsulation` when they can create two independent `Service` objects and explain why two variables may also refer to one shared object.

If prerequisite syntax is the main difficulty, recommend `$dotnet-oop-foundations`.
