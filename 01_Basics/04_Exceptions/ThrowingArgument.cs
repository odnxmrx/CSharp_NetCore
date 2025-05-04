namespace _01_Basics._04_Exceptions;

public class ThrowingArgument
{
    public static int CheckParameterAndThrowException1(int i)
    {
        // TODO 4-1. Add the code to throw the ArgumentException if the i argument is odd.
        if (i % 2 != 0)
        {
            throw new ArgumentException("i should not be odd.", nameof(i));
        }

        return i;
    }

    public static ushort CheckParameterAndThrowException2(ushort s)
    {
        // TODO 4-2. Add the code to throw the ArgumentException if the s argument equals zero.
        if (s == 0)
        {
            throw new ArgumentException("s should not equals zero.", nameof(s));
        }

        return s;
    }

    public static long CheckParameterAndThrowException3(long l)
    {
        // TODO 4-3. Add the code to throw the ArgumentException if the l argument is even.
        if (l % 2 == 0)
        {
            throw new ArgumentException("l should not be even.", nameof(l));
        }

        return l;
    }

    public static int CheckParameterAndThrowException4(float[] floats)
    {
        // TODO 4-4. Add the code to throw the ArgumentException if the floats array is empty.
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

    public static int CheckParameterAndThrowException5(string s)
    {
        // TODO 4-5. Add the code to throw the ArgumentException if the s string is empty.
        if (s is null)
        {
            throw new ArgumentNullException(nameof(s));
        }

        if (s.Length == 0)
        {
            throw new ArgumentException("s string is empty.", nameof(s));
        }

        return s.Length;
    }
}