using System;
using _02_BasicCalculator;

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

    result = Calculate(operand1, operand2, operatorSymbol); //calling method

    Console.WriteLine();
    Console.WriteLine($"{operand1} {operatorSymbol} {operand2} = {result} ");
}
catch(CalculationResultOverflowException ex)
// ex -> pasa a es el  error lanzado ('CalculationResultOverflowException(ex.Message, ex)')
// del 'Calculate' method.
{
    Console.WriteLine();
    //The original overflow exception is stored in the innerException prop (a string). of the 'ex' obj.
    Console.WriteLine($"Inner Exception (IE): {ex.InnerException?.Message}");
    //? -> prevent 'null' exception from being thrown
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Red;
    //Console.WriteLine(ex.Message);
    Console.WriteLine($"The desired result is our of range for an Integer value (i.e. between {Int32.MinValue} and {Int32.MaxValue}).");
    Console.ResetColor();
}
catch (OverflowException ex) //Entering out of range values for Int datatypes
{
    Console.WriteLine();
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.WriteLine("This value is either too big or too small for an Integer value.");
    Console.ResetColor();
}
catch (DivideByZeroException ex)
{
    Console.WriteLine();
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.WriteLine("For a division, the 2nd operand cannot be '0'.");
    Console.ResetColor();
}
catch (ArithmeticException ex)
{
    //Console.Clear(); //Clear Console to display Error Msg
    Console.WriteLine();
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Red;
    
    Console.WriteLine(ex.Message);
    
    Console.ResetColor();
}
catch (FormatException ex)
{
    Console.WriteLine();
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message); //Error Msg from Exception
    //Console.WriteLine("input value is invalid");
    Console.ResetColor();
}
finally
{
    Console.ResetColor();
    Console.WriteLine("Press any key to exit program...");
}

Console.ReadKey(); //Esperar por user input

//private?
static int Calculate(int operand1, int operand2, char operatorSymbol) //int value of operation 
{
    int result = 0;
    try
    {
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
            default: //faltaría manejar error para el 'OperandSymbol'
                throw new InvalidOperationException();
        }
    }
    catch (OverflowException ex) //out of value range
    {
        throw new CalculationResultOverflowException(ex.Message, ex);
    }
    catch(InvalidOperationException ex)
    {
        throw new ArgumentException($"{nameof(operatorSymbol)} is invalid.");
        /*
        the msj passed to this CTOR, includes a 'nameof' method -> it has passed one of the param names
        included in the Calculate methods signature.
        nameof -> included in C# 6
        */
    }
    catch(DivideByZeroException ex)
    {
        throw new ArgumentException($"{nameof(operand2)} cannot be 0 with divide operation");
    }
    return result;
}