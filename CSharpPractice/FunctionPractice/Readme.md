# FunctionPractice

A small .NET 10 console application for practising fundamental C# concepts.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Optional: Visual Studio Code with the **C# Dev Kit** extension for interactive debugging

## Run the application

From this directory, run:

```bash
dotnet run
```

The active program in `Program.cs` runs examples of single, multiple, multilevel, and hierarchical inheritance.

## Debug the application

### Visual Studio Code

1. Open this folder in VS Code.
2. Open `Program.cs`.
3. Click in the left margin beside an executable line, such as `InheritanceTypesDemo.RunAll();`, to set a breakpoint.
4. Press `F5` and choose the **C#** debugger if prompted.
5. When execution pauses, inspect values in the Variables panel or step into a method and hover over its local variables.
6. Use `F10` to step over a line and `F11` to step into a method.

### Command line

Build the project and view compiler errors with:

```bash
dotnet build
```

## Examples in the project

`Program.cs` contains commented calls that can be enabled one at a time to run a particular exercise.

| Topic | Type or method | What it demonstrates |
| --- | --- | --- |
| Conditions | `ComparisonExamples.Show` | `if` / `else if` / `else` age checks |
| Switch statements | `ComparisonExamples.DemoSwitch` | Selecting behaviour from a colour value |
| Loops | `ComparisonExamples.DemopForLoop` | A `for` loop from 0 through 10 |
| Arrays | `NewCollections.DemoArray` | Iterating through a string array |
| Lists | `NewCollections.DemoList` | Adding, changing, removing, searching, and iterating values |
| ArrayList | `NewCollections.ArryList` | A non-generic collection alongside `List<int>` |
| Hashtable and Dictionary | `NewCollections.HashTable`, `NewCollections.DicTable` | Key/value collections |
| Stack and Queue | `NewCollections.Stack`, `NewCollections.Queue` | LIFO and FIFO collection behaviour |
| Fields and methods | `Company`, `CompanySetter` | Public fields and updating object state |
| Encapsulation | `CompanySetter2` | Reading and changing private data through public methods |
| Constructors | `MyConstructorClass` | Initialising objects with overloaded constructors |
| Single inheritance | `Vehicle`, `Car` | One derived class inherits from one base class |
| Multiple inheritance (interfaces) | `ICanFly`, `ICanSwim`, `Duck` | One class implements behaviour from multiple interfaces |
| Multilevel inheritance | `CompanyInheritance`, `EmpInheritance`, `Boss`, `IEmployeeSalary` | A boss inherits company data through the employee class and implements salary behaviour |
| Hierarchical inheritance | `Shape`, `Circle`, `Square` | Several derived classes inherit from the same base class |

## Inheritance revision guide

### Quick comparison

| Type | Structure | Project example | Key point |
| --- | --- | --- | --- |
| Single inheritance | `A → B` | `Vehicle → Car` | One child inherits from one parent. |
| Multiple inheritance | `A + B → C` | `ICanFly` + `ICanSwim` → `Duck` | C# uses interfaces; a class cannot inherit from two classes. |
| Multilevel inheritance | `A → B → C` | `CompanyInheritance → EmpInheritance → Boss` | The last class inherits members through every earlier level. |
| Hierarchical inheritance | `A → B` and `A → C` | `Shape → Circle` and `Shape → Square` | Multiple children share the same parent. |

### Remember

- `:` means **inherits from** for classes, for example `class Car : Vehicle`.
- `:` also means **implements** when a class lists interfaces, for example `class Duck : ICanFly, ICanSwim`.
- A derived class can access public members from its base class.
- `base(...)` calls the constructor of the parent class.
- Constructors execute from parent to child in an inheritance chain.

## Multilevel inheritance example

The project uses a three-level inheritance chain:

```text
CompanyInheritance
        ^
        |
EmpInheritance ---- implements ----> IEmployeeSalary
        ^
        |
      Boss
```

`EmpInheritance` derives from `CompanyInheritance`, so it receives `CompanyId`, `CompanyName`, and `DisplayData()`. `Boss` derives from `EmpInheritance`, so it receives those company members plus `EmpId`, `EmpName`, `Salary`, `DisplayEmployeeData()`, and `SalaryDetails()`.

`Boss` adds its own `Department` property and `DisplayBossData()` method. This is multilevel inheritance: the final class can use members from every class earlier in the chain. C# does not support multiple class inheritance, but a class can implement multiple interfaces.

## Other inheritance types

### Single inheritance

One derived class inherits from one base class.

```text
Vehicle
   ^
   |
  Car
```

`Car` inherits `Start()` from `Vehicle` and adds `Drive()`.

### Multiple inheritance through interfaces

C# cannot inherit from multiple classes. Instead, one class can implement multiple interfaces.

```text
ICanFly     ICanSwim
    ^          ^
     \        /
       Duck
```

`Duck` implements both `Fly()` and `Swim()`.

### Hierarchical inheritance

Multiple derived classes inherit from the same base class.

```text
        Shape
       ^     ^
       |     |
   Circle  Square
```

Both `Circle` and `Square` inherit `Describe()` from `Shape`, then add their own drawing methods.

## Revision questions

1. Which inheritance type is shown by `Vehicle → Car`?
2. Why does `Duck` implement interfaces instead of inheriting from two classes?
3. Which class is the direct parent of `Boss`?
4. What members can `Boss` use from `CompanyInheritance`?
5. Why are `Circle` and `Square` an example of hierarchical inheritance?

<details>
<summary>Answers</summary>

1. Single inheritance.
2. C# does not allow a class to inherit from more than one class; interfaces provide multiple behaviours.
3. `EmpInheritance`.
4. `CompanyId`, `CompanyName`, and `DisplayData()`.
5. They are different derived classes that share the same base class, `Shape`.

</details>

## Learning reference

- [C# collections tutorial — YouTube](https://www.youtube.com/watch?v=j0USw7vMvDc&list=PLEp2QJywZxwHDdvVR1_-oomyuxWCjLCgx&index=7)
