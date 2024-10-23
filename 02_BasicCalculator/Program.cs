using System;
using System.Runtime.CompilerServices;
using _02_BasicCalculator;

int operand1, operand2;
int result = 0; //initialized (final log purpose)
char operatorSymbol;

//Const con nombre de los params de Calculate
const string operator_Symbol = "OPERATORSYMBOL";
const string operand_1 = "OPERAND1";
const string operand_2 = "OPERAND2";


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
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine();
//     Console.BackgroundColor = ConsoleColor.White;
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine(ex.Message);
//     Console.WriteLine("For  'division' operation, the 2nd operand cannot be of '0'.");
//     Console.ResetColor();
// }
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
catch(ArgumentException ex)
{
    WriteArgumentExceptionToScreen(ex); //eval which param caused the exception and throw its message
    // Console.WriteLine();
    // Console.BackgroundColor = ConsoleColor.White;
    // Console.ForegroundColor = ConsoleColor.Red;
    // //Console.WriteLine(ex.Message); // xx 'is invalid.'
    // Console.WriteLine("Eror: Input value is invalid.");
    // Console.ResetColor();
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
        throw new ArgumentException($"{nameof(operatorSymbol)} is invalid.",operator_Symbol,ex); //nameof(operand2) retornaría el op2 as string
        /*
        the msj passed to this CTOR, includes a 'nameof' method -> it has passed one of the param names
        included in the Calculate methods signature.
        nameof -> included in C# 6
            ADVANTAGE: if we change the name of the parameter in the Calculate methods signature
            a compile time error would be flagged; forcing us to rename the relevant param. passed
        */
    }
    catch(DivideByZeroException ex)
    {
        throw new ArgumentException($"{nameof(operand2)} cannot be '0' with divide operation",operand_2,ex);
    } // Other: Argument out of range exception (class)
    return result;
}

//Evaluate the param names of the args excep thrown; based on param name, we can print a specific message:
static void WriteArgumentExceptionToScreen(ArgumentException ex)
{
    string errorMessage = null;

    if(ex?.ParamName.ToUpper() == operator_Symbol) //Evaluate the param entered
    {
        errorMessage = "Invalid operator sym was entered. Operators allowed: +, -, *, /";
    }
    else if (ex.ParamName.ToUpper() == operand_2)
    {
        errorMessage = "A value of 0 was entered for the 2nd operand. This value cannot be 0 when executing a divide operation.";
    }
    WriteExceptionMessageToScreen(errorMessage);
}


//Generic method to write msg in console
static void WriteExceptionMessageToScreen(string message)
{
    Console.WriteLine();
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message); // specific 
    //Console.WriteLine("Eror: Input value is invalid.");
    Console.ResetColor();
}