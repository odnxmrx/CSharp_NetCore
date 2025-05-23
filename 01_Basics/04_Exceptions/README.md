# Exceptions

## ArgumentOutOfRangeException

### Subtask 1-1

Add the code to test if an _i_ argument is in the allowable range, and throw an _ArgumentOutOfRangeException_ when the argument is outside the allowable range.


| i Interval    | Allowable Range | Exception                   |
|---------------|-----------------|-----------------------------|
| (-&infin; -5] | No              | ArgumentOutOfRangeException |
| (-5, 5)       | Yes             |                             |
| [5, &infin;)  | No              | ArgumentOutOfRangeException |

### Subtask 1-2

Add the code to test if an _l_ argument is in the allowable range, and throw an _ArgumentOutOfRangeException_ when the argument is outside the allowable range.

| l Interval    | Allowable Range | Exception                   |
|---------------|-----------------|-----------------------------|
| (-&infin; 0)  | No              |                             |
| [0, 7]        | Yes             |                             |
| (7, &infin;)  | No              | ArgumentOutOfRangeException |

There is no need to test if an _l_ argument is less than zero, because _l_ is of unsigned data type.

#### Subtask 1-3

Add the code to test if both _i_ and _d_ arguments are in the allowable ranges, and throw the _ArgumentOutOfRangeException_ when any of the method arguments is outside the allowable range.

| Parameter | Interval        | Allowable Range | Exception                   | Error Message                        |
|-----------|-----------------|-----------------|-----------------------------|--------------------------------------|
| i         | (-&infin; 0)    | No              |                             |                                      |
| i         | [0, 5)          | Yes             |                             |                                      |
| i         | [5, &infin;)    | No              | ArgumentOutOfRangeException | i should be in [0, 5) interval.      |
| d         | (-&infin; -1.0) | No              | ArgumentOutOfRangeException | d should be in [-1.0, 1.0] interval. |
| d         | [-1.0, 1.0]     | Yes             |                             |                                      |
| d         | (1.0, &infin;)  | No              | ArgumentOutOfRangeException | d should be in [-1.0, 1.0] interval. |

#### Subtask 1-4

Add the code to test if both _l_ and _f_ arguments are in the allowable ranges, and throw the _ArgumentOutOfRangeException_ when any of the method arguments is outside the allowable range.

| Parameter | Interval        | Allowable Range | Exception                   | Error Message                                |
|-----------|-----------------|-----------------|-----------------------------|----------------------------------------------|
| l         | (-&infin; -9)   | No              | ArgumentOutOfRangeException | l should be in [-9, -3) or [3, 9) intervals. |
| l         | [-9, -3)        | Yes             |                             |                                              |
| l         | [-3, 3)         | No              | ArgumentOutOfRangeException | l should be in [-9, -3) or [3, 9) intervals. |
| l         | [3, 9)          | Yes             |                             |                                              |
| l         | [9, &infin;)    | No              | ArgumentOutOfRangeException | l should be in [-9, -3) or [3, 9) intervals. |
| f         | (-&infin; -0.3] | No              | ArgumentOutOfRangeException | f should be in the (-0.3, 0.3) interval.     |
| f         | (-0.3, 0.3)     | Yes             |                             |                                              |
| f         | [0.3, &infin;)  | No              | ArgumentOutOfRangeException | f should be in the (-0.3, 0.3) interval.     |

## ArgumentNullException

_The exception that is thrown when a **null reference is passed to a method** that does not accept it as a valid argument._


#### Subtask 2-1

Add the _if_ statement to test if an _o_ argument is _null_, and throw the _ArgumentNullException_ when the argument is null.

```cs
public static bool CheckParameterAndThrowException1(object o)
{
    if (o == null)
    {
        throw new ArgumentNullException(nameof(o));
    }

    return true;
}
```

Beginning with C# 7.0, you can use a [constant pattern](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#constant-pattern) to check for _null_.

```cs
public static bool CheckParameterAndThrowException1(object o)
{
    if (o is null)
    {
        throw new ArgumentNullException(nameof(o));
    }

    return true;
}
```

"if (o is null)" is the **preferred syntax** in the modern C#.


#### Subtask 2-2

Add the _if_ statement to test if _o1_ or _o2_ arguments is _null_, and throw the _ArgumentNullException_ when any of the method arguments is null.

The _ArgumentNullException_ class has a [constructor with two string parameters](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception.-ctor?view=net-6.0#system-argumentnullexception-ctor(system-string-system-string)) that allows to specify an error message:

```cs
public ArgumentNullException (string? paramName, string? message);
```

Usually having an error message is not needed for an _ArgumentNullException_, because the issue is described by the exception type. In this task you don't have to specify an error message for an _ArgumentNullException_.


#### Subtask 2-3

Add the code to test if the method argument (_integers_, _longs_ and _floats_) is _null_, and throw an _ArgumentNullException_ when any of the method arguments is null.


#### Subtask 2-4

Add the code to test if a string argument is null, and throw the _ArugmentNullException_ when the argument is null.

```cs
public static int CheckParameterAndThrowException4(string s)
{
    if (s is null)
    {
        throw new ArgumentNullException(nameof(s));
    }

    return s.Length;
}
```


#### Subtask 2-5

Add the code to throw the _ArgumentNullException_ when any of the method arguments is null.


#### Subtask 2-6

Add the code to throw the _ArgumentNullException_ when any of the method arguments is null.


### The Null-coalescing Operator ??

Read the [?? and ??= operators](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator) documentation article, learn examples section.


#### Subtask 2-7

Add the code to throw the _ArgumentNullException_ when an _integers_ argument is null.

1. Add the parenthesis around the _integer_ parameter.

```cs
public static int CheckParameterAndThrowException7(int[] integers)
{
    int integersCount;

    integersCount = (integers).Length;

    return integersCount;
}
```

2. Add the null-coalescing operator to throw the _ArgumentNullException_ when an _integer_ argument is null.

```cs
public static int CheckParameterAndThrowException7(int[] integers)
{
    int integersCount;

    integersCount = (integers ?? throw new ArgumentNullException()).Length;

    return integersCount;
}
```

3. Use the _nameof_ expression to specify the _integer_ parameter name.

```cs
public static int CheckParameterAndThrowException7(int[] integers)
{
    int integersCount;

    integersCount = (integers ?? throw new ArgumentNullException(nameof(integers))).Length;

    return integersCount;
}
```


#### Subtask 2-8

Add the code to throw the _ArgumentNullException_ when any of the method arguments is null.


#### Subtask 2-9

Add the code to throw the _ArgumentNullException_ when any of the method arguments is null.

## The Null-coalescing Assignment Operator ??=

#### Subtask 3-1

Add the code to initialize the _o_ parameter with the default value when the _o_ argument is null.

| Parameter | Default Value |
|-----------|---------------|
| o         | new object()  |

Use the [null-coalescing assignment operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator):

```cs
public static object CheckParameterAndThrowException7(object o)
{
    o ??= new object();

    return o;
}
```


#### Subtask 3-2

Add the code to initialize the _integers_ parameter with the default value when the _integers_ argument is null.

| Parameter | Default Value   |
|-----------|-----------------|
| integers  | new int[] { 0 } |


#### Subtask 3-3

Add the code to initialize the _s_ parameter with the default value when the _s_ argument is null.

| Parameter | Default Value   |
|-----------|-----------------|
| s         | "Hello, world!" |

The string parameters are initialized in the same way as the object and the array parameters:

```cs
public static string CheckParameterAndThrowException3(string s)
{
    s ??= "Hello, world!";

    return s;
}
```


#### Subtask 3-4

Add the code to initialize the _s1_ and _s2_ parameters with the default values when _s1_ or _s2_ argument is null.

| Parameter | Default Value   |
|-----------|-----------------|
| s1        | "Hello"         |
| s2        | "world"         |


#### Subtask 3-5

Add the code to initialize the method parameters with the default values when any argument is null.

| Parameter | Default Value         |
|-----------|-----------------------|
| s1        | "abc"                 |
| integers  | new int[] { 1, 2, 3 } |
| s2        | "123"                 |


## ArgumentException

Read the [ArgumentException class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception) documentation article. Study examples and remarks sections.

The class description says:

_The exception that is thrown when one of the arguments provided to a method **is not valid**._


#### Subtask 4-1


Add the code block to throw the _ArgumentException_ when _i_ argument is odd. The exception's error message should be "i should not be odd.".

1. Add the _if_ statement that tests if an _i_ is odd. To check if a number is odd use the [remainder operator %](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators) to compute the remainder after dividing an _i_ by 2, and test if the operation result is not equal zero.

```cs
public static int CheckParameterAndThrowException1(int i)
{
    if (i % 2 != 0)
    {
    }

    return i;
}
```

2. Add the _throw_ expression to throw the _ArgumentOutOfRangeException_.

```cs
public static int CheckParameterAndThrowException1(int i)
{
    if (i % 2 != 0)
    {
        throw new ArgumentException();
    }

    return i;
}
```

3. Specify the error message.

```cs
public static int CheckParameterAndThrowException1(int i)
{
    if (i % 2 != 0)
    {
        throw new ArgumentException("i should not be odd.");
    }

    return i;
}
```

4. Use the _nameof_ expression to specify the _i_ parameter name.

```cs
public static int CheckParameterAndThrowException1(int i)
{
    if (i % 2 != 0)
    {
        throw new ArgumentException("i should not be odd.", nameof(i));
    }

    return i;
}
```

Pay attention that the error message parameter goes first in the [ArgumentException constructors](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception.-ctor).

```cs
public ArgumentException(string? message, string? paramName);
```


#### Subtask 4-2

Add the code to throw the _ArgumentException_ when _s_ argument equals zero. The error message should be "s should not equals zero.".


#### Subtask 4-3

Add the code to throw the _ArgumentException_ when _l_ argument is even. The error message should be "l should not be even.".


#### Subtask 4-4

Add the code to throw the _ArgumentException_ when the _floats_ array has no elements. The error message should be "floats array has no elements.".

1. Add an _if_ statement that tests if the _floats_ array is empty.

```cs
public static int CheckParameterAndThrowException4(float[] floats)
{
    if (floats.Length == 0)
    {
    }

    return floats.Length;
}
```

2. Add an _throw_ expression to throw the _ArgumentException_ when the _floats_ array is empty. Specify the error message and the parameter name in the exception constructor.

```cs
public static int CheckParameterAndThrowException4(float[] floats)
{
    if (floats.Length == 0)
    {
        throw new ArgumentException("floats array has no elements.", nameof(floats));
    }

    return floats.Length;
}
```
3. In such cases it makes sense to add an additional check for testing an argument for _null_. Add an _if_ statement that throws the _ArgumentNullException_ when the _floats_ argument is _null_.

```cs
public static int CheckParameterAndThrowException4(float[] floats)
{
    if (floats is null)
    {
        throw new ArgumentNullException(nameof(floats));
    }

    if (floats.Length == 0)
    {
        throw new ArgumentException("floats array has no elements.", nameof(floats));
    }

    return floats.Length;
}
```


#### Subtask 4-5

Add the code to throw the _ArgumentException_ when the _s_ string is empty. The error message should be "s string is empty.". Also, add the code to throw an _ArgumentNullException_ when _s_ argument is _null_.

## Handling Exceptions with try...catch


#### Subtask 5-1

Add the code to return the _false_ when an _ArgumentOutOfRangeException_ is thrown.

| Exception Type To Catch     | Return |
|-----------------------------|--------|
| ArgumentOutOfRangeException | false  |

1. Add the try-catch statement to catch the _ArgumentOutOfRangeException_.

```cs
public static bool CatchArgumentOutOfRangeException1(int i, Func<int, bool> foo)
{
    try
    {
        return foo(i);
    }
    catch (ArgumentOutOfRangeException)
    {
    }
}
```

2. Add return statement to return _false_.

```cs
public static bool CatchArgumentOutOfRangeException1(int i, Func<int, bool> foo)
{
    try
    {
        return foo(i);
    }
    catch (ArgumentOutOfRangeException)
    {
        return false;
    }
}
```


#### Subtask 5-2

Add the code to return the "K139" string when an _ArgumentOutOfRangeException_ is thrown. Assign the _errorMessage_ parameter to the exception error message.

| Exception Type To Catch     | Return | errorMessage Parameter                |
|-----------------------------|--------|---------------------------------------|
| ArgumentOutOfRangeException | K139   | Assign to the exception error message. |

1. Add a try-catch statement to catch the _ArgumentOutOfRangeException_.

```cs
public static string CatchArgumentOutOfRangeException2(int i, object o, string s, out string errorMessage)
{
    errorMessage = null;

    try
    {
        return DoSomething(i, o, s);
    }
    catch (ArgumentOutOfRangeException)
    {
    }
}
```

2. Add return statement to return "K139" string.

```cs
public static string CatchArgumentOutOfRangeException2(int i, object o, string s, out string errorMessage)
{
    errorMessage = null;

    try
    {
        return DoSomething(i, o, s);
    }
    catch (ArgumentOutOfRangeException)
    {
        return "K139";
    }
}
```

3. Assign an [exception error message](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.message) to the _errorMessage_ parameter.

```cs
public static string CatchArgumentOutOfRangeException2(int i, object o, string s, out string errorMessage)
{
    errorMessage = null;

    try
    {
        return DoSomething(i, o, s);
    }
    catch (ArgumentOutOfRangeException e)
    {
        errorMessage = e.Message;
        return "K139";
    }
}
```


#### Subtask 5-3

Add the code to return the "P456" string when an _ArgumentNullException_ is thrown.

| Exception Type To Catch     | Return |
|-----------------------------|--------|
| ArgumentNullException       | P456   |


#### Subtask 5-4

Add the code to return the "A732" string when an _ArgumentNullException_ is thrown. Assign the _errorMessage_ parameter to the exception error message.

| Exception Type To Catch     | Return | errorMessage Parameter                |
|-----------------------------|--------|---------------------------------------|
| ArgumentNullException       | A732   | Assign to the exception error message. |


#### Subtask 5-5

Add the code to return the "0" value when an _ArgumentException_ is thrown.

| Exception Type To Catch     | Return |
|-----------------------------|--------|
| ArgumentException           | 0      |


#### Subtask 5-6

Add the code to return the "D948" string when an _ArgumentException_ is thrown. Assign the _errorMessage_ parameter to the exception error message.

| Exception Type To Catch     | Return | errorMessage Parameter                 |
|-----------------------------|--------|----------------------------------------|
| ArgumentException           | D948   | Assign to the exception error message. |


#### Subtask 5-7

Add a try-catch statement to catch three exception types - ArgumentException, ArgumentNullException and ArgumentOutOfRangeException.

| Exception Type To Catch     | Return | errorMessage Parameter                |
|-----------------------------|--------|---------------------------------------|
| ArgumentException           | J954   | Assign to an exception error message. |
| ArgumentNullException       | W694   | Assign to an exception error message. |
| ArgumentOutOfRangeException | Z029   | Assign to an exception error message. |

The _ArgumentNullException_ and _ArgumentOutOfRangeException_ classes [derive from the ArgumentException class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception), therefore the _ArgumentNullException_ and the _ArgumentOutOfRangeException_ classes are more specific then the _ArgumentException_ class. When catching multiple exceptions in the same try-catch block, you have to catch the more specific exceptions [before the less specific ones](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch).

If you order your catch blocks so that a less specific exception goes before the more specific ones, the compiler produces the [CS0160 error](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0160).

