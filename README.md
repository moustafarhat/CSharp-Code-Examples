# C# Design Patterns

[![CI](https://github.com/moustafarhat/CSharp-Code-Examples/actions/workflows/ci.yml/badge.svg)](https://github.com/moustafarhat/CSharp-Code-Examples/actions/workflows/ci.yml)
![.NET 10](https://img.shields.io/badge/.NET-10-512BD4)

Classic Gang of Four design patterns and the SOLID principles, written in modern C# (.NET 10) with a unit test suite.

Each example uses a small, realistic domain instead of `Foo` and `Bar`. The tests show how each pattern is used and what it guarantees, so treat them as the documentation.

## Patterns

### Creational

| Pattern | Example | Use it when | Think twice when | Code |
|---|---|---|---|---|
| **Singleton** | Application-wide sequence number generator | Exactly one instance must exist, such as a shared counter or cache | You only want "one per app". A DI container's singleton lifetime is easier to test | [src](src/DesignPatterns/Creational/Singleton) · [tests](tests/DesignPatterns.Tests/Creational/SingletonTests.cs) |
| **Factory Method** | Loggers: file, database, console | A base class has the workflow, but subclasses choose which object to create | There's only one product. Just call `new` | [src](src/DesignPatterns/Creational/FactoryMethod) · [tests](tests/DesignPatterns.Tests/Creational/FactoryMethodTests.cs) |
| **Abstract Factory** | Phone brands that each make a smartphone and a feature phone | Products come in families that must not be mixed | There's only one family, or products are unrelated | [src](src/DesignPatterns/Creational/AbstractFactory) · [tests](tests/DesignPatterns.Tests/Creational/AbstractFactoryTests.cs) |
| **Builder** | Fluent `VehicleBuilder` plus a director with preset models | An object has many optional parts and must be valid once built | A constructor or `required` init properties already read well | [src](src/DesignPatterns/Creational/Builder) · [tests](tests/DesignPatterns.Tests/Creational/BuilderTests.cs) |
| **Prototype** | Customer templates that are cloned, not rebuilt | Creating from scratch is expensive or repetitive, and there's a good "template" instance | Objects hold resources that can't be copied, such as connections or handles | [src](src/DesignPatterns/Creational/Prototype) · [tests](tests/DesignPatterns.Tests/Creational/PrototypeTests.cs) |

### Structural

| Pattern | Example | Use it when | Think twice when | Code |
|---|---|---|---|---|
| **Composite** | Files and directories with recursive sizes | Clients should treat a single item and a group of items the same way | The structure isn't really a tree | [src](src/DesignPatterns/Structural/Composite) · [tests](tests/DesignPatterns.Tests/Structural/CompositeTests.cs) |
| **Decorator** | Car packages stacked on any car | Features can be combined freely, and a subclass per combination would explode | The order of wrapping matters in surprising ways, or you need the concrete type back | [src](src/DesignPatterns/Structural/Decorator) · [tests](tests/DesignPatterns.Tests/Structural/DecoratorTests.cs) |

### Behavioral

| Pattern | Example | Use it when | Think twice when | Code |
|---|---|---|---|---|
| **Strategy** | Calculator with swappable operations | Several algorithms are interchangeable and chosen at runtime | There are only two branches. An `if` or a `Func<>` is enough | [src](src/DesignPatterns/Behavioral/Strategy) · [tests](tests/DesignPatterns.Tests/Behavioral/StrategyTests.cs) |
| **State** | Order lifecycle: New → Shipped → Delivered, or Cancelled | An object's allowed actions depend on its state, and `switch (Status)` is spreading everywhere | There are few states and the rules are simple | [src](src/DesignPatterns/Behavioral/State) · [tests](tests/DesignPatterns.Tests/Behavioral/StateTests.cs) |
| **Command** | Bank deposits, withdrawals and transfers with a queue and undo | Requests need to be queued, retried, logged or undone | You just need to call a method | [src](src/DesignPatterns/Behavioral/Command) · [tests](tests/DesignPatterns.Tests/Behavioral/CommandTests.cs) |

## SOLID principles

Each principle has a `Before` file that breaks it and an `After` file that fixes it.

| Principle | Before ❌ | After ✅ | Code |
|---|---|---|---|
| **S**ingle responsibility | An invoice that calculates and prints itself | A calculator and a printer that change for different reasons | [src](src/DesignPatterns/Solid/SingleResponsibility) |
| **O**pen/closed | A `switch` on customer type for discounts | `IDiscountPolicy`: new discounts are new classes | [src](src/DesignPatterns/Solid/OpenClosed) |
| **L**iskov substitution | An `Enquiry` "customer" that throws when saved | Capabilities split into `IDiscountable` and `IPersistable` | [src](src/DesignPatterns/Solid/LiskovSubstitution) |
| **I**nterface segregation | A printer forced to implement scan and fax | Small `IPrinter`, `IScanner` and `IFax` interfaces | [src](src/DesignPatterns/Solid/InterfaceSegregation) |
| **D**ependency inversion | A service that creates its own file logger | Constructor injection, wired by a test fake or by `Microsoft.Extensions.DependencyInjection` | [src](src/DesignPatterns/Solid/DependencyInversion) |

Tests: [SolidTests.cs](tests/DesignPatterns.Tests/Solid/SolidTests.cs)

## Running it

You need the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0).

```bash
dotnet test
```

The build treats warnings as errors and runs the recommended .NET code analyzers. CI also checks formatting with `dotnet format --verify-no-changes`.

## Project layout

```
src/DesignPatterns/          Pattern implementations, grouped by category
tests/DesignPatterns.Tests/  xUnit tests, mirroring the same structure
```

## Background

This repository started in 2019–2020 as my C# learning notebook: about 100 small console projects covering language basics, collections and first attempts at design patterns. In 2026 I rewrote the design pattern part as this project. Compared with the originals, this version:

- targets .NET 10 instead of .NET Framework 4.6 and .NET Core 2.1
- has real tests for every pattern instead of a placeholder test project
- fixes bugs from the originals, such as integer division in the Strategy calculator (`3 / 4` returned `0`)
- keeps console output out of the library, so every behaviour can be asserted on

The original examples are preserved under the [`legacy-2020`](https://github.com/moustafarhat/CSharp-Code-Examples/tree/legacy-2020) tag.
