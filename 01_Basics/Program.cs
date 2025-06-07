// See https://aka.ms/new-console-template for more information

using _01_Basics._01_Integers;

Console.WriteLine("Hello, World!");

//Constants
Console.WriteLine("Const values:");
Console.WriteLine(Constants.ReturnLargestInteger());
Console.WriteLine(Constants.ReturnSmallestInteger());
Console.WriteLine(Constants.ReturnLargestUnsignedInteger());
Console.WriteLine(Constants.ReturnSmallestUnsignedInteger());
Console.WriteLine(Constants.ReturnLargestLongInteger());
Console.WriteLine("");

// Integer literals
Console.WriteLine("Integer literals:");
Console.WriteLine(Integers.ReturnInteger11());
Console.WriteLine(Integers.ReturnInteger12());
Console.WriteLine(Integers.ReturnInteger13());
Console.WriteLine(Integers.ReturnInteger14());
Console.WriteLine(Integers.ReturnInteger15());
Console.WriteLine(Integers.ReturnInteger16());
Console.WriteLine(Integers.ReturnInteger17());
Console.WriteLine(Integers.ReturnInteger18());
Console.WriteLine("");


int CountNarcissisticNumbers(int n) 
{ 
    int i, j, k, m, c, p; double s; 
 
    i = 0; c = 0; 
    while (i < n) 
    { 
        j = i; p = 0; 
        while (j != 0) 
        { 
            p++; 
            j /= 10; 
        } 
 
        j = i; s = 0; 
        while (j != 0) 
        { 
            k = 0; m = 1; 
            while (k < p)
            { 
                m *= j % 10; 
                k++; 
            } 
 
            s += m; 
            j /= 10;
        } 
 
        c = c + (s == i ? 1 : 0); 
        i++; 
    } 
 
    return c;	 
} 

Console.WriteLine(CountNarcissisticNumbers(153));
Console.WriteLine(CountNarcissisticNumbers(9474));