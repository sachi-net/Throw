# Throw
`Throw` is a unified conditional validator designed for .NET built-in structures and types. `Throw` also simplifies multi-level guard conditions such as `if-else` and `switch` statements into single-line validator. Interneally, `Throw` extends behaviors of built-in types when its namespace is referred within current coding context.

## Prerequisites
Currently, Throw is available for local installation only. Throw requires [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0) (v5.#.#) or [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) (v6.#.#).

## Quick Overview
`Throw` can change this
```C#
int? age = 50;

if (age is null)
  throw new Exception();

if (age is 0)
  throw new Exception("Are you kidding?");
  
if (age < 0)
  throw new Exception("This is fake!");
  
if (age > 12 && )

```
