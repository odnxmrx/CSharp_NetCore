namespace _01_Basics._05_While;

public class WhileLoopFive
{
    /// <summary>
    /// Calculate the following product
    /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
    /// </summary>
    /// <param name="n">Number of elements.</param>
    /// <returns>Product of elements.</returns>
    public static double GetSequenceProduct(int n)
    {
        decimal i = 1;
        decimal result = 1;

        while (i <= n)
        {
            decimal denominatorPow = i * i;
            decimal denominator = 1 / denominatorPow;
            result *= 1 + denominator;
            i++;
        }

        return (double)result;
    }
}