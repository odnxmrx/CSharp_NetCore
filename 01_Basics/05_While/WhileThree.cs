namespace _01_Basics._05_While;

public static class WhileThree
{
    public static double SumSequenceElements(int n)
    {
        int count = 1;
        double sum = 0d;

        while (count <= n)
        {
            int innerCount = 1;
            double denominator = count;
            while (innerCount < 5)
            {
                denominator *= count;
                innerCount++;
            }

            sum += (1 / denominator);
            count++;
        }

        return sum;
    }
}