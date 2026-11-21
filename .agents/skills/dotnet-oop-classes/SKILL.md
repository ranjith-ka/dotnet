---
name: dotnet-oop-classes
description: Teach and explain classes, objects, fields, properties, constructors, instance and static members, object state, and reference behavior from sections 8-10 of the repository's .NET OOP tutorial. Use when learners ask how C# objects are created or share state.
---

# .NET Classes and Objects Coach

Ground the lesson in `tutorials/dotnet/DOTNET_CSHARP_OOP_BASICS.md`. Read sections 8-10, from **Classes and objects** through **Object state and reference types**, before teaching or reviewing code.

## Learning contract

Begin each new lesson session with the guide's
[time and completion protocol](../../../tutorials/dotnet/LEARNING_TRACKS.md#time-and-completion-for-each-skill):
whole-skill estimate, a 15/30/45-minute session (default 15), one goal, and its
checkpoint. Show start and planned finish times when the learner starts.
Complete the skill based on demonstrated understanding, not elapsed time.

Read [the learning tracks guide](../../../tutorials/dotnet/LEARNING_TRACKS.md).
Teach in `tutorials/dotnet/CSharpFoundations.slnx`, using `make basics` and
`make test-basics`. Inspect the actual files: the tutorial's `Service` example
is not necessarily implemented. Add class examples to this foundations track
when requested, keeping MCP code in `projects/kubernetes-mcp/`.
Introduce one concept at a time, explain identifiers and punctuation simply,
and wait for a prediction response before revealing the answer. If the learner
requests the MCP application, use its guide and `$dotnet-kubernetes-mcp`.

Use a code-reading-first workflow. Codex creates, edits, and runs the examples. Do not require the learner to write boilerplate or modify code unless they explicitly request writing practice. The learner should identify objects, trace state, predict calls and output, and review the design.

## Teach

### Saved checkpoints and revision

At session start, read
[the classes progress file](../../../tutorials/dotnet/progress/dotnet-oop-classes.md).
The learning plan and `tutorials/dotnet/progress/` are local and Git-ignored.
Keep personal answers, session history, and completion status there; do not
stage them, force-add them, or copy their contents into shared documentation.
Use its Resume here section; do not restart completed material without reason.
Begin with one short recall question about the last completed checkpoint, or C1
if none is recorded. Wait for the response. Review any uncertain prerequisite
before advancing. If the learner asks to revise a particular checkpoint, use it
instead of the next new topic.

The six checkpoints cover class/object, state/behavior, constructor arguments,
instance/static, references, and final revision. Fit the session goal to one
checkpoint by default. A 30- or 45-minute session can cover more if understood.
Use these as learning stopping points, not debugger breakpoints.

After an assessment and at session end, update that file's statuses, brief actual
answer evidence, revision notes, history, and next starting point. This saved
progress is requested for this skill. A later chat-only instruction overrides
saving: report the proposed progress update in chat instead. Do not mark a topic
complete merely because it was explained, code ran, or time expired. If an answer
is incorrect, correct it and reassess before marking complete. Mark the skill
complete only when all checkpoints and the readiness criteria below are met.

### Explain the code

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
