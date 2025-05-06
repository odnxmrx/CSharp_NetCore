namespace _01_Basics._05_While;

public class WhileLoopOne
{
    /// <summary>
    /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
    /// </summary>
    /// <param name="n">Number of elements.</param>
    /// <returns>Sum of elements.</returns>
    public static double SumSequenceElements(int n)
    {
        Console.WriteLine($"valor de n: {n}");
        double sumValue = 0d;
        int i = 1;
        // Console.WriteLine($"valor de i en un incio: {i}");
        while (i <= n)
        {
            // sumValue += (1 / n) + (1 / n + 1);
            sumValue += 1.0 / i;
            i++;
            // Console.WriteLine($"valor de i despues: {i}");
        }

        return sumValue;
    }
}