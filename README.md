# Throw
`Throw` is a unified conditional validator designed for .NET built-in structures and types. `Throw` also simplifies multi-level guard conditions such as `if-else` and `switch` statements into single-line validator. Interneally, `Throw` extends the behaviors of built-in types when its namespace is referred within current coding context.

## Prerequisites
Currently, Throw is available for local installation only. Throw requires [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0) (v5.#.#) or [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) (v6.#.#).

## Quick Demo
`Throw` can easily transform this 👇
```C#
int? age = 47;

if (age is null)
  throw new Exception();

if (age is 0)
  throw new Exception("Are you kidding?");
  
if (age < 0)
  throw new Exception("This is unreal!");
  
if (age >= 13 && age <= 19)
  throw new Exception("Teenagers not allowed!");
```
into a single minified expression like... 👇
```C#
age.Throw()
  .WhenNull()
  .WhenZero("Are you kidding?")
  .WhenNegative("This is unreal!")
  .WhenInRange(13, 19, "Teenagers not allowed!");
```
#### _In other words, `Throw` can translate imperative flow of validations into a declarative statement_
> **Note** &nbsp; There are more validations which can be done by `Throw` with other types as well...

## Implementation Overview
`Throw` provides these additional validatable functions on different types as _Extension methods_. There are two main constructs within `Throw` library which extends other types. They are...
* `Thrower`  
Thrower construct extends the validatability of .NET built-in types using the extension method named `Throw`. Literally, `Throw` is used to throw exceptions on an event of failing any given validation on that type extended by the Thrower. For example,
```C#
int? age = 47;
age.Throw().WhenNull().WhenZero().WhenNegative();
```
* `Runner`  
Runner construct extends the validatability of .NET built-in types using the extension method named `Run`. This is used to invoke an external function on an event of failing any given validation on that type extended by the Runner. For example,
```C#
int? age = 47;
age.Run(TerminateRequest).WhenNull().WhenZero().WhenNegative();

void TerminateRequest() => Console.WriteLine("Bad Request by invalid age!");
```

Both of these are accessible in any context by the namespace reference of `using Throw.Extensions;` at the top-level or in global-usings. These enable the extensions on following constructs.
#### Numeric constructs
* `sbyte`, `sbyte?`
* `byte`, `byte?`
* `short`, `short?`
* `ushort`, `ushort?`
* `int`, `int?`
* `uint`, `uint?`
* `long`, `long?`
* `ulong`, `ulong?`
* `float`, `float?`
* `double`, `double?`
* `decimal`, `decimal?`

#### Non-Numeric constructs
* `string`
* `bool`, `bool?`
* `DateTime`, `DateTime?`
* `Enum`
* `Type`
* `ICollection<T>`
* `T` as any generic type

> **Warning** The extensions on generic type `T` is available for any construct where the type is from `class`.

### Thrower Extensions
Thrower provides following three extensions on the above structures.

|Extension|Description|
|--|--|
|`Throw()`|Initialize to throw exception based on construct value or its properties|
|`Throw(string)`|Initialize to throw exception based on construct value or its properties with a custom message|
|`Throw(Exception)`|Initialize to throw custom exception based on construct value or its properties|

### Runner Extensions
Runner provides following three extensions on the above structures.

|Extension|Description|
|--|--|
|`Run(Action)`|Initialize to invoke the action based on construct value or its properties|
