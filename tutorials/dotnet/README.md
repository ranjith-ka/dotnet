# .NET tutorials

| Tutorial | For | Path |
|----------|-----|------|
| **C# Basics and OOP for DevOps** | Syntax, classes, objects, constructors, state, and encapsulation | [DOTNET_CSHARP_OOP_BASICS.md](./DOTNET_CSHARP_OOP_BASICS.md) |

The OOP tutorial has four local teaching skills:

1. `$dotnet-oop-foundations`
2. `$dotnet-oop-classes`
3. `$dotnet-oop-encapsulation`
4. `$dotnet-oop-lab`

## Practice programs

1. [Operators and string interpolation](./practice/02-operators/Program.cs)

Run the operators tests after changing its logic:

```bash
make run
```

This runs the tests first and runs the application only when every test passes.

Run only the tests with `make test`. The longer commands `make dotnet-operators`
and `make dotnet-operators-test` remain available.

The SDK configuration accepts later .NET 10 feature bands, including 10.0.301.
