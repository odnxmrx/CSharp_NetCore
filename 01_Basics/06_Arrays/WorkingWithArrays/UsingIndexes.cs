namespace _01_Basics._06_Arrays.WorkingWithArrays;

public static class UsingIndexes
{
    public static int GetFirstArrayElement(int[] array)
    {
        return array?[0] ?? throw new ArgumentNullException(nameof(array));
    }

    public static bool GetFirstArrayElement(bool[] array)
    {
        return array?[0] ?? throw new ArgumentNullException(nameof(array));
    }

    public static string GetFirstArrayElement(string[] array)
    {
        return array?[0] ?? throw new ArgumentNullException(nameof(array));
    }
}