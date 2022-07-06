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

#### _`Throw` can easily chain multiple validations into a single in-line statement_

---
## Table of Contents
+ [Prerequisites](#prerequisites)
+ [Quick Demo](#quick-demo)
+ [Implementation Overview](#implementation-overview)
  + [`Thrower` Extensions](#thrower-extensions)
  + [`Runner` Extensions](#runner-extensions)
+ [Validators](#validators)
  + [Validator Enums](#validator-enums)
    + [`Boundary` Enum](#boundary-enum)
  + [Supported Constructs](#supported-constructs)
    + [Numeric constructs](#numeric-constructs)
    + [Non-Numeric constructs](#non-numeric-constructs)
  + [Numeric Validators](#numeric-validators)
  + [String Validators](#string-validators)
  + [Boolean Validators](#boolean-validators)
  + [DateTime Validators](#datetime-validators)
  + [Enum Validators](#enum-validators)
  + [Type Validators](#type-validators)
  + [Collection Validators](#collection-validators)
  + [Custom Type Validators](#custom-type-validators)

---

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

Both of these are accessible in any context by the namespace reference of `using ThrowValidator.Extensions;` at the top-level or in global-usings. These enable the extensions on following constructs.
### Supported Constructs
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
* `T` as any generic custom type

> **Warning** The extensions on generic type `T` is available for any construct where the type is from `class`.

### Thrower Extensions
Thrower provides following three extensions on the above structures.

|Extension|Description|
|--|--|
|`Throw()`|Initialize to throw exception based on construct value or its properties|
|`Throw(string)`|Initialize to throw exception based on construct value or its properties with a custom message|
|`Throw(Exception)`|Initialize to throw custom exception based on construct value or its properties|

For example,
```C#
int number = -10;

// Throws default ArgumentException with default message
// "Value cannot be negative."
number.Throw().WhenNegative().WhenZero();

// Throws default ArgumentException with custom message
// "Invalid value."
number.Throw("Invalid value.").WhenNegative().WhenZero();

// Throws default ArgumentException with custom messages per each validator
// "Value must be positive." when number is less than 0
// "Value cannot be zero." when number is equal to 0
number.Throw()
    .WhenNegative("Value must be positive.")
    .WhenZero("Value cannot be zero.");

// Throws custom Exception with custom message for all validators
// "Oh no! Wrong value."
number.Throw(new MyException("Oh no! Wrong value.")).WhenNegative().WhenZero();
```

### Runner Extensions
Runner provides following three extensions on the above structures.

|Extension|Description|
|--|--|
|`Run(Action)`|Initialize to invoke the action based on construct value or its properties|

For example,
```C#
int number = -10;
void TerminateRequest() => Console.WriteLine("Bad Request due to invalid value!");

// Run the parameterless function "TerminateRequest" when any validation is failed
number.Run(TerminateRequest).WhenNegative().WhenZero();
```

## Validators
`Throw` provides numerous useful validators based on the selected .NET construct type (`struct` or `class`). The available [Numeric](#numeric-constructs) and [Non-Numeric](#non-numeric-constructs) constructs are listed above. All of these validators can be accessed by both `Thrower` and `Runner` extensions as well.

### Validator Enums
Currently, `Throw` has following enumerations.
#### Boundary Enum
`Boundary` enum can be used to validate a given value against a specified range. Commonly, available Range validators take three arguments as `left`, `right` values and `Boundary` enum.
|Option|Description|
|--|--|
|`Inclusive`|Include both left and right margins while evaluating the range. `left ≤ value ≤ right`|
|`Exclusive`|Exclude both left and right margins while evaluating the range. `left < value < right`|
|`LeftOnly`|Include only left but not the right margins while evaluating the range. `left ≤ value < right`|
|`RightOnly`|Include only right but not the left margins while evaluating the range. `left < value ≤ right`|

> **Note** &nbsp; Range validators expects lower value as the `left` margin and higher value as the `right` margin.

> **Warning** &nbsp; Range validators will swap-out the `left` and `right` margins as it expects, when the provided `left` argument is larger than the provided `right` argument.

### Numeric Validators
The following validators are available for all [numeric constructs](#numeric-constructs) listed in above [Implementation Overview](#implementation-overview) section.
```C#
number.Throw().When(() => number % 10 == 0, "Number cannot be multiple of 10."); // Triggers when meet the custom condition.
number.Throw().WhenEqualTo(9, "Number cannot be 9."); // Triggers when this construct value is equal to the given value.
number.Throw().WhenGreaterThan(5, "Number cannot be greater than 5."); // Triggers when this construct value is greater than the given value.
number.Throw().WhenGreaterThanOrEqualTo(5, "Number cannot be 5 or greater than 5."); // Triggers when this construct value is greater than or equal to the given value.
number.Throw().WhenInRange(5, 9, Boundary.Exclusive, "Number cannot be in between 5 and 9."); // Triggers when this construct value is within the given range excluding the boundaries.
number.Throw().WhenLessThan(5, "Number cannot be less than 5."); // Triggers when this construct value is less than the given value.
number.Throw().WhenLessThanOrEqualTo(5, "Number cannot be 5 or less than 5."); // Triggers when this construct value is less than or equal to the given value.
number.Throw().WhenNegative("Number cannot be negative."); // Triggers when this construct value is negative. (less than zero)
number.Throw().WhenNotEqualTo(5, "Number must not be 5."); // Triggers when this construct value is not equal to the given value.
number.Throw().WhenNull("Number cannot be null."); // Triggers when this construct value is null.
number.Throw().WhenOutOfRange(5, 9, Boundary.Inclusive, "Number cannot be out of range between 5 and 9."); // Triggers when this construct value is not in the given range including the boundaries.
number.Throw().WhenPositive("Number cannot be positive."); // Triggers when this construct value is positive. (greater than zero)
number.Throw().WhenZero("Number cannot be zero."); // Triggers when this construct value is equal to zero.
```
> **Note** &nbsp; `WhenNull([string])` validator triggers its validations with nullable types only.

### String Validators
```C#
name.Throw().When(() => string.Join(" ", namesList).Equals(name)), "This user is not allowed."); // Triggers when meet the custom condition.
name.Throw().WhenContain('S', "Name cannot contain letter S."); // Triggers when this string contain given character. (Case sensitive)
name.Throw().WhenContain("Sachi", "Name cannot contain Sachi."); // Triggers when this string contain given string. (Case sensitive)
name.Throw().WhenContain('s', StringComparison.OrdinalIgnoreCase, "Name cannot contain letter S."); // Triggers when this string contain given character.
name.Throw().WhenContain("sachi", StringComparison.OrdinalIgnoreCase, "Name cannot contain Sachi."); // Triggers when this string contain given string.
name.Throw().WhenEmpty("Name cannot be empty."); // Triggers when this string is empty.
name.Throw().WhenEndWith("Silva", "Name cannot ends with Silva."); // Triggers when this string ends with given string. (Case sensitive)
name.Throw().WhenEndWith("silva", StringComparison.OrdinalIgnoreCase, "Name cannot ends with Silva."); // Triggers when this string ends with given string.
name.Throw().WhenEqualTo("Sachi", "Name cannot be Sachi."); // Triggers when this string is equal to given string. (Case sensitive)
name.Throw().WhenEqualTo("sachi", StringComparison.OrdinalIgnoreCase, "Name cannot be Sachi."); // Triggers when this string is equal to given string.
name.Throw().WhenLengthEqualTo(5, "Name length cannot be 5."); // Triggers when the length of this string is equal to the given limit.
name.Throw().WhenLengthLongerThan(5, "Name length cannot exceed 5."); // Triggers when the length of this string is greater than the given limit.
name.Throw().WhenLengthNotEqualTo(5, "Name length is not 5."); // Triggers when the length of this string is not equal to the given limit.
name.Throw().WhenLengthShorterThan(5, "Name must have at least 5 characters."); // Triggers when the length of this string is less than the given limit.
name.Throw().WhenMatchWith(@"^[0-9]+$", "Name cannot be a number."); // Triggers when this string matches with the given string pattern.
name.Throw().WhenMatchWith(new Regex(@"^[0-9]+$"), "Name cannot be a number."); // Triggers when this string matches with the given regular expression.
name.Throw().WhenMatchWith(@"^[0-9]+$", RegexOptions.CultureInvariant, "Name cannot be a number."); // Triggers when this string matches with the given string pattern using regular expression options.
name.Throw().WhenNotContain('S', "Name does not contain letter S."); // Triggers when this string does not contain given character. (Case sensitive)
name.Throw().WhenNotContain("Sachi", "Name does not contain Sachi."); // Triggers when this string does not contain given string. (Case sensitive)
name.Throw().WhenNotContain('s', StringComparison.OrdinalIgnoreCase, "Name does not contain letter S."); // Triggers when this string does not contain given character.
name.Throw().WhenNotContain("sachi", StringComparison.OrdinalIgnoreCase, "Name does not contain Sachi."); // Triggers when this string does not contain given string.
name.Throw().WhenNotEndWith("Silva", "Name does not end with Silva."); // Triggers when this string does not end with given string. (Case sensitive)
name.Throw().WhenNotEndWith("silva", StringComparison.OrdinalIgnoreCase, "Name does not end with Silva."); // Triggers when this string does not end with given string.
name.Throw().WhenNotEqualTo("Sachi", "Name does not equal to Sachi."); // Triggers when this string is not equal to given string. (Case sensitive)
name.Throw().WhenNotEqualTo("sachi", StringComparison.OrdinalIgnoreCase, "Name does not equal to Sachi."); // Triggers when this string is not equal to given string.
name.Throw().WhenNotMatchWith(@"^[a-z]+$", "Invalid name."); // Triggers when this string does not matche with the given string pattern.
name.Throw().WhenNotMatchWith(new Regex(@"^[a-z]+$"), "Invalid name."); // Triggers when this string does not matche with the given regular expression.
name.Throw().WhenNotMatchWith(@"^[a-z]+$", RegexOptions.IgnoreCase, "Invalid name."); // Triggers when this string does not matche with the given string pattern using regular expression options.
name.Throw().WhenNotStartWith("Sachi", "Name does not start with Sachi."); // Triggers when this string does not start with given string. (Case sensitive)
name.Throw().WhenNotStartWith("sachi", StringComparison.OrdinalIgnoreCase, "Name does not start with Sachi."); // Triggers when this string does not start with given string.
name.Throw().WhenNull("Name cannot be null."); // Triggers when this string is null.
name.Throw().WhenStartWith("Sachi", "Name cannot start with Sachi."); // Triggers when this string starts with given string. (Case sensitive)
name.Throw().WhenStartWith("sachi", StringComparison.OrdinalIgnoreCase, "Name cannot start with Sachi."); // Triggers when this string starts with given string.
name.Throw().WhenWhiteSpaces("Name cannot have only white-spaces."); // Triggers when this string has only white-spaces.
```

### Boolean Validators
```C#
isConnected.Throw().When(() => isConnected && !application.IsRunning, "Application is connected but not running."); // Triggers when meet the custom condition.
isConnected.Throw().WhenFalse("Application is not connected."); // Triggers when this boolean value is false.
isConnected.Throw().WhenNull("Connection state cannot be null."); // Triggers when this boolean value is null.
isConnected.Throw().WhenTrue("Application is connected."); // Triggers when this boolean value is true.
```

### DateTime Validators
```C#
birthDay.Throw().When(() => age < 18, "Users below 18yrs are not allowed."); // Triggers when meet the custom condition.
birthDay.Throw().WhenEqualTo(DateTime.Now, "New borns not allowed."); // Triggers when this date-time value is equal to the given date-time.
birthDay.Throw().WhenGreaterThan(new DateTime(2000, 1, 1), "You are too young."); // Triggers this date-time value is greater than the given date-time.
birthDay.Throw().WhenGreaterThanOrEqualTo(new DateTime(2000, 1, 1), "You are too young."); // Triggers this date-time value is greater than or equal the given date-time.
birthDay.Throw().WhenInRange(new DateTime(1970, 1, 1), new DateTime(1980, 12, 31), Boundary.Inclusive, "Birth year between 1970 and 1980 is not allowed"); // Triggers when this date-time value is within given left and right date range including the boundaries.
birthDay.Throw().WhenLessThan(new DateTime(1950, 1, 1), "You are too old."); // Triggers when this date-time value is less than the given date-time.
birthDay.Throw().WhenLessThanOrEqualTo(new DateTime(1950, 1, 1), "You are too old."); // Triggers when this date-time value is greater less or equal the given date-time.
birthDay.Throw().WhenNotEqualTo(DateTime.Now, "New borns are only allowed."); // Triggers when this date-time value is not equal to the given date-time.
birthDay.Throw().WhenNull("Birthday cannot be null."); // Triggers when this date-time value is null.
birthDay.Throw().WhenOutOfRange(new DateTime(1970, 1, 1), new DateTime(1980, 12, 31), Boundary.Exclusive, "Birth year outside of 1970 and 1980 is not allowed"); // Triggers when this date-time value is outside of given left and right date range excluding the boundaries.
```

> **Note** &nbsp; `WhenNull([string])` validator triggers its validations with nullable types only.

### Enum Validators
```C#
boundaryEnum.Throw().When(() => boundaryEnum == Boundary.Inclusive, "Invalid enum value."); // Triggers when meet the custom condition.
boundaryEnum.Throw().WhenEqualTo(Boundary.LeftOnly, "Boundary cannot apply LeftOnly."); // Triggers when this enum value is equalts to the given enum value
boundaryEnum.Throw().WhenNull("Boundary value cannot be null."); // Triggers when this enum value is null.
boundaryEnum.Throw().WhenOutOfRange(-5, "-5 index is not defined in Boundary."); // Triggers when the given enum index is not defined in this enum.
```

### Type Validators
```C#
myType.Throw().When(() => myType == otherType.GetType(), "Type cannot be another."); // Triggers when meet the custom condition.
myType.Throw().WhenEqualTo(typeof(int), "Type cannot be an integer."); // Triggers when this type is equal to the given type.
myType.Throw().WhenNotEqualTo(typeof(string), "Type is not a string."); // Triggers when this type is not equal to the given type.
myType.Throw().WhenNull("Type cannot be null."); // Triggers when this type is null.
```

### Collection Validators
Collection validators are available for collection types which implements `ICollection<T>` interface. Check-out the following `Person` class implementation and how collection validators are applied on a list of `Person` objects.
```C#
public class Person : IEquatable<Person> {
    public string Name { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public bool IsMarried { get; set; }

    public bool Equals(Person other)
    {
      if (other is null)
        return false;

      return other.Name.Equals(Name) && other.Address.Equals(Address) && 
        other.Age == Age && other.IsMarried == IsMarried;
    }
}
```
Consider collection validators on `ICollection<Person> peopleGroup` list.
```C#
peopleGroup.Throw().When(() => myAge > 50, "I should not older than 50 for this group."); // Triggers when meet the custom condition.
peopleGroup.Throw().WhenAny(p => p.Age > 50 && !p.IsMarried, "Unmarried people over 50 are not allowed."); // Triggers when this collection has any element which satisfies the given predicate.
peopleGroup.Throw().WhenContain(personSachi, "Sachi cannot be in this group."); // Triggers when this collection contains the given element.
peopleGroup.Throw().WhenCountEqualTo(10, "Group cannot have 10 members."); // Triggers when this collection has exact number of elements specified.
peopleGroup.Throw().WhenCountGreaterThan(10, "Group cannot have more than 10 members."); // Triggers when this collection count is greater than the specified length.
peopleGroup.Throw().WhenCountGreaterThanOrEqualTo(10, "Group cannot have 10 or more members."); // Triggers when this collection count is greater or equal to the specified length.
peopleGroup.Throw().WhenCountLessThan(10, "Group must have atleast 10 members."); // Triggers when this collection count is less than the specified length.
peopleGroup.Throw().WhenCountLessThanOrEqualTo(10, "Group members cannot be 10 or below."); // Triggers when this collection count is less or equal to the specified length.
peopleGroup.Throw().WhenCountNotEqualTo(10, "Group does not have 10 members."); // Triggers when this collection has no exact number of elements specified.
peopleGroup.Throw().WhenEmpty("Group does not have any members."); // Triggers when this collection has no elements.
peopleGroup.Throw().WhenNotContain(personSachi, "Sachi is not in this group."); // Triggers when this collection does not contains the given element.
peopleGroup.Throw().WhenNotEmpty("Group must not have any members."); // Triggers when this collection has at least one element. (not empty)
peopleGroup.Throw().WhenNull("Group cannot be null."); // Triggers when this type is null.
```

> **Note** &nbsp; The collection object of type `T` must implement `IEquatable<T>` interface in order to allow `WhenContain` and `WhenNotContain` validators to perform necessary lookups within the list.

### Custom Type Validators
Any construct of type `class` will have custom generic type validators. Consider the `Person` class described in [Collection Validator](#collection-validator) section and how generic type validators are applied on `Person person` object.
```C#
person.Throw().When(() => person.Age % 10 > 5, "Age over 5 decades are not allowed."); // Triggers when meet the custom condition.
person.Throw().When(p => !p.IsMarried && p.Age > 35, "Come-on man... you still haven't married."); // Triggers when meet the condition on this type.
person.Throw().WhenNot(p => p.Age > 12 && p.Age < 20, "This is for teenagers only."); // Triggers when does not meet the condition on this type.
person.Throw().WhenNull("Person cannot be null."); // Triggers when this type is null.
```

> **Warning** &nbsp; Custom type validators are available for any `class` type constructs. The other validators implemented in `Throw` may not visible on an object if its type is not same as the validator is defined for.
