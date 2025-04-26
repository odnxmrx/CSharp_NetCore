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

