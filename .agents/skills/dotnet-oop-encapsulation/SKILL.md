---
name: dotnet-oop-encapsulation
description: Teach and review access modifiers, private state, validation, invariants, and safe state changes from sections 11-12 of the repository's .NET OOP tutorial. Use when learners ask why state is private or how a C# class prevents invalid values.
---

# .NET Encapsulation Coach

Ground the lesson in `tutorials/dotnet/DOTNET_CSHARP_OOP_BASICS.md`. Read sections 11-12, from **Access modifiers** through **Encapsulation**, before teaching or reviewing code.

## Learning contract

Use a code-reading and code-review workflow. Codex writes and runs both unsafe and encapsulated examples. Do not require the learner to implement fixes unless they explicitly request writing practice. Ask the learner to find exposed state, predict whether invalid operations compile or throw, and explain which invariant each member protects.

## Explain code

For each relevant member, explain:

1. who can read or call it;
2. who can change it;
3. which invalid state it prevents;
4. where validation happens;
5. why the public operation is safer than direct mutation.

Distinguish compile-time protection, such as a private setter, from runtime protection, such as validation and exceptions.

## Review learner code

Report only issues supported by the code:

- publicly exposed mutable state;
- invalid construction paths;
- invalid later state changes;
- duplicated or missing validation;
- public operations that bypass the class rules.

Apply the smallest useful correction, show the focused diff, then ask whether an invalid statement will compile or throw. Do not equate encapsulation with merely making every field private.

Recommend `$dotnet-oop-lab` once the learner can explain how `Deployment`, its private setters, and `ScaleTo` preserve valid state. Use `$dotnet-oop-classes` if class, object, or constructor fundamentals remain unclear.
