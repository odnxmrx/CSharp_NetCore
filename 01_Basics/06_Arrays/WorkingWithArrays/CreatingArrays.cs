namespace _01_Basics._06_Arrays.WorkingWithArrays;

public static class CreatingArrays
{
    public static int[] CreateEmptyArrayOfIntegers()
    {
        return new int[0];
    }
    
    public static bool[] CreateEmptyArrayOfBooleans()
    {
        bool[] array = { };
        return array;
    }
    
    // Using the Array.Empty<T> method
    public static double[] CreateEmptyArrayOfDoubles()
    {
        return Array.Empty<double>();
    }

    public static float[] CreateEmptyArrayOfFloats()
    {
        return Array.Empty<float>();
    }
    
    // Creating arrays with default values
    public static int[] CreateArrayOfTenIntegersWithDefaultValues()
    {
        return new int[10];
    }

    public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
    {
        return new bool[20];
    }
    
    // Creating arrays with elements
    public static int[] CreateIntArrayWithOneElement()
    {
        int[] arr = [123_456];
        return arr;
    }

    public static int[] CreateIntArrayWithTwoElements()
    {
        var arr = new[] { 1_111_111, 9_999_999 };
        return arr;
    }
}