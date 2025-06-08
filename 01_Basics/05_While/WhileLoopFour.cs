namespace _01_Basics._05_While;

public class WhileLoopFour
{
    /// <summary>
    /// Calculate the following sum
    /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
    /// </summary>
    /// <param name="n">Number of elements.</param>
    /// <returns>Sum of elements.</returns>
    public static double SumSequenceElements(int n)
    {
        int i = 1;
        double result = 0d;
        while (i <= n)
        {
            double denominator = (2 * i) + 1;
            denominator *= denominator;

            result += (1 / denominator);
            i++;
        }

        return result;
    }
}