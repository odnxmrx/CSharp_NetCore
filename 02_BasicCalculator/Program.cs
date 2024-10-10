using System;

int operand1, operand2;
int result = 0; //initialized (final log purpose)
char operatorSymbol;

Console.WriteLine("Basic Calculator");
Console.WriteLine("-----------------");

try
{
        
    Console.WriteLine("Please, enter a whole number (first operand):");
    operand1 = int.Parse(Console.ReadLine()); //parse to Integer 

    Console.WriteLine("Please, enter a whole number (second operand):");
    operand2 = int.Parse(Console.ReadLine()); //parse to Integer 

    Console.WriteLine("Please, enter a valid operator symbol:");
    Console.WriteLine("'+', '-', '*', '/'");
    operatorSymbol = char.Parse(Console.ReadLine()); //convert to str to char

    //operator case:
    switch (operatorSymbol)
    {
        case '+':
            checked
            {
                result = operand1 + operand2;
            }
            break;
        case '-':
            checked
            {
                result = operand1 - operand2;
            }
            break;
        case '*':
            checked // force the CLR to perform overflow checks by this 'Int' vals
            {
                result = operand1 * operand2;
            }
            break;
        case '/':
            checked
            {
            result = operand1 / operand2;
            }
            break;
        default:
            break;
    }

    Console.WriteLine();
    Console.WriteLine($"{operand1} {operatorSymbol} {operand2} = {result} ");
}
catch (Exception ex)
{
    //Console.Clear(); //Clear Console to display Error Msg
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Red;
    
    Console.WriteLine(ex.Message);
    
    Console.ResetColor();
}
finally
{
    Console.WriteLine("Press any key to exit program...");
}

Console.ReadKey(); //Esperar por user input