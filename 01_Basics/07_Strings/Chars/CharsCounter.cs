namespace _01_Basics._07_Strings.Chars;

public static class CharsCounter
{
    public static int GetCharsCount(string? str, char[]? chars)
    {
        ArgumentNullException.ThrowIfNull(str);
        ArgumentNullException.ThrowIfNull(chars);
        int counter = 0;
        if (string.IsNullOrEmpty(str))
        {
            return counter;
        }
        
        // Iterar sobre string para contar chars
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < chars.Length; j++)
            {
                if (str[i] == chars[j])
                {
                    counter++;
                }
            }
        }
        
        return counter;
    }
}