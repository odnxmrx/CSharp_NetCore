# Tasks

## Task 1
Implement the method that returns sum of an arithmetic sequence terms if the common difference is 1.

$`\sum_{i=1}^{n} a+(i-1)*1=\sum_{i=0}^{n-1} a+i`$

For the arithmetic sequence $`{5, 6, 7, 8, 9, ...}`$ the sum of the first five elements is 35 (5 + 6 + 7 + 8 + 9).


### Task 2

Implement the method that returns the sum of an arithmetic sequence elements when the first term is 17 and the common difference is 33.

$`\sum_{i=1}^{n} 17+(i-1)*33=\sum_{i=0}^{n-1} 17+i*33`$

Beginner programmers often put number literals in their code like this:

```cs
public static int SumArithmeticSequenceTerms2(int n)
{
    int sum = 0, i = 0;

    while (i < n)
    {
        sum += 17 + (i * 33);
        i++;
    }

    return sum;
}
```

Experienced programmers consider using number literals with unexplained meaning as a *bad practice*. They call such literals [magic numbers](https://en.wikipedia.org/wiki/Magic_number_(programming)).
