namespace _01_Basics._05_While;

public class PowerLoopTwo
{
    /// <summary>
    /// Calculate the following sum
    /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
    /// </summary>
    /// <param name="n">Number of elements.</param>
    /// <returns>Sum of elements.</returns>
    public static double SumSequenceElements(int n)
    {
        double sumValue = 0d;

        int i = 1;

        while (i <= n)
        {
            int otherCount = 1;

            double numerator = -1;

            while ((i + 1) > otherCount)
            {
                numerator *= -1;
                otherCount++;
            }

            double denominator = i * (i + 1);

            sumValue += numerator / denominator;

            i++;
        }

        return sumValue;
    }
}