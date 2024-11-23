namespace _03_Delegates;

public class Program
{
    delegate void LogDelegate(string text); //delegate definition
    
    public static void Main(string[] args)
    {
        LogDelegate logDelegate = new LogDelegate(LogTextToScreen);
        Console.WriteLine("Hello, what's your name?");
        
        var name = Console.ReadLine();
        
        logDelegate("Hello " + name);

        Console.ReadKey();
    }
    
    static void LogTextToScreen(string text)
    {
        Console.WriteLine($"{DateTime.Now} {text}");
    }
}