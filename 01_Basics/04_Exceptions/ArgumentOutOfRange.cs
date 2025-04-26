namespace _01_Basics._04_Exceptions;

public class ArgumentOutOfRange
{
    public static bool CheckParameterAndThrowException1(int i)
    {
        // TODO 1-1. Add the code to throw the ArgumentOutOfRangeException if the i argument is outside the allowable range.
        if (i <= -5 || i >= 5)
        {
            throw new ArgumentOutOfRangeException(nameof(i));
        }

        return true;
    }
    
    public static bool CheckParameterAndThrowException2(ulong l)
    {
        // TODO 1-2. Add the code to throw the ArgumentOutOfRangeException if the l argument is outside the allowable range.
        if (l > 7)
        {
            throw new ArgumentOutOfRangeException(nameof(l));
        }

        return true;
    }

    public static bool CheckParametersAndThrowException3(uint i, double d)
    {
        // TODO 1-3. Add the code to throw the ArgumentOutOfRangeException if the i and d arguments are outside the allowable range.
        if (i >= 5)
        {
            throw new ArgumentOutOfRangeException(nameof(i), "i should be in [0, 5) interval.");
        }

        if (d < -1.0 || d > 1.0)
        {
            throw new ArgumentOutOfRangeException(nameof(d), "d should be in [-1.0, 1.0] interval.");
        }

        return true;
    }

    public static bool CheckParametersAndThrowException4(long l, float f)
    {
        // TODO 1-4. Add the code to throw the ArgumentOutOfRangeException if the l and f arguments are outside the allowable range.
        if (l < -9 || (l >= -3 && l < 3) || l >= 9)
        {
            throw new ArgumentOutOfRangeException(nameof(l), "l should be in [-9, -3) or [3, 9) intervals.");
        }

        if (f <= -0.3 || f >= 0.3)
        {
            throw new ArgumentOutOfRangeException(nameof(f), "f should be in the (-0.3, 0.3) interval.");
        }

        return true;
    }
}