# dotnet
for Learning purpose

Updated by Github Copilot

## .NET Core vs .NET Framework
- .NET Core is a cross-platform implementation of .NET that is primarily used to build web applications and services that run on Windows, Linux and Mac. It can also be used to build console applications and libraries that run on Windows, Linux and Mac. It is open source and is supported by Microsoft and the .NET community on GitHub.
- .NET Framework is a Windows-only version of .NET for building any type of app that runs on Windows.
- .NET Core is cross-platform, .NET Framework is Windows-only.
- .NET Core is open source and community-oriented, .NET Framework is open source but governed by Microsoft.
- .NET Core is supported by Microsoft and the .NET community, .NET Framework is supported by Microsoft.
- .NET Core is modular, .NET Framework is monolithic.
- .NET Core is a .NET implementation, .NET Framework is a .NET implementation + set of libraries, frameworks and tools.
- .NET Core is a smaller set of libraries, .NET Framework is a larger set of libraries.
- .NET Core is a single .NET implementation, .NET Framework is a family of .NET implementations (e.g. WPF, UWP, Xamarin).
- .NET Core is a newer and growing framework, .NET Framework is a mature framework.
- .NET Core is the future of .NET, .NET Framework is in maintenance mode.
- .NET Core is better suited for modern cloud applications, .NET Framework is better suited for traditional client-server applications.
- .NET Core is better suited for microservices, .NET Framework is better suited for monoliths.
- .NET Core is better suited for containerized applications, .NET Framework is better suited for virtualized applications.
- .NET Core is better suited for applications that need to run side-by-side with other applications, .NET Framework is better suited for applications that need to run on the same machine.
- .NET Core is better suited for high-performance and scalable systems, .NET Framework is better suited for high-availability systems.
- .NET Core is better suited for applications that require fast development cycles, .NET Framework is better suited for applications that require stable development cycles.

## .NET Core
- .NET Core is a cross-platform, open-source, and modular .NET platform for creating modern web apps, microservices, libraries and console applications.

### .NET Core Architecture
- .NET Core is a modular implementation of .NET that can be used as the base stack for a wide variety of scenarios, today scaling from console utilities to web apps in the cloud. It is also suitable for creating portable libraries that run on multiple platforms. The .NET Core platform is open source, using MIT and Apache 2 licenses. It is supported by Microsoft and the .NET community on GitHub.

### .NET Core Components
- .NET Core consists of the following components:
  - .NET Compiler Platform (Roslyn)
  - Common Language Runtime (CLR)
  - CoreFX
  - CoreCLR
  - CoreRT
  - CoreFX Lab
  - CoreFX Lab
  - CoreFX is the foundational class libraries for .NET Core. It includes types for collections, file systems, console, JSON, XML, async and many others. These types are used by the .NET Core runtime, but are available to use in your own apps too.
  - CoreCLR is the .NET Core runtime. It includes the garbage collector, JIT compiler, primitive data types and low-level classes.
  - CoreRT is an ahead-of-time (AOT) compiler for .NET Core. It is used to compile .NET Core apps into native binaries that run without a runtime on multiple platforms.
  - CoreFX Lab is a prototype of new ideas for the .NET Core foundational libraries. It includes types for collections, file systems, console, JSON, XML, async and many others. These types are used by the .NET Core runtime, but are available to use in your own apps too.
  - .NET Compiler Platform (Roslyn) is a set of open-source compilers and code analysis APIs for C# and Visual Basic .NET languages. It is used by the .NET Core SDK to compile C# and Visual Basic .NET code.

## .NET Framework

### .NET Framework Architecture
- .NET Framework is a software framework developed by Microsoft that runs primarily on Microsoft Windows. It includes a large class library called Framework Class Library (FCL) and provides language interoperability (each language can use code written in other languages) across several programming languages. Programs written for .NET Framework execute in a software environment (as contrasted to hardware environment) named Common Language Runtime (CLR), an application virtual machine that provides services such as security, memory management, and exception handling. FCL and CLR together constitute .NET Framework.

### .NET Framework Components
- .NET Framework consists of the following components:
  - Common Language Runtime (CLR)
  - Framework Class Library (FCL)
  - Dynamic Language Runtime (DLR)
  - Application Domains
  - Runtime Host
  - Common Type System (CTS)
  - Metadata and Assemblies
  - Windows Workflow Foundation (WF)
  - Windows Presentation Foundation (WPF)
  - Windows Communication Foundation (WCF)
  - LINQ
  - Windows CardSpace
  - ADO.NET
  - ASP.NET