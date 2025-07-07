namespace _01_Basics._05_While;

public class WhileLoopSix
{
    public static double SumSequenceElements(int n)
    {
        int i = 1;
        double result = 0d;

        int currentSign = -1;

        while (i <= n)
        {
            double denominator = (2 * i) + 1;
            result += currentSign / denominator;

            // Alternar simbolo
            currentSign *= -1;
            i++;
        }

        return result;
    }
}