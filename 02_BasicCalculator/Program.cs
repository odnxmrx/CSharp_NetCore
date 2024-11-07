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
    operand1 = ValidateOperandInput(); //int.Parse(Console.ReadLine()); //parse to Integer 

    Console.WriteLine("Please, enter a whole number (second operand):");
    operand2 = ValidateOperandInput(); //int.Parse(Console.ReadLine()); //parse to Integer 

    Console.WriteLine("Please, enter a valid operator symbol:");
    Console.WriteLine("'+', '-', '*', '/'");
    operatorSymbol = ValidateOperatorInput(); //char.Parse(Console.ReadLine()); //convert to str to char

    result = Calculate(operand1, operand2, operatorSymbol); //calling method

    Console.WriteLine();
    Console.WriteLine($"{operand1} {operatorSymbol} {operand2} = {result} ");
}
catch(CalculationResultOverflowException ex)
// ex -> pasa a es el  error lanzado ('CalculationResultOverflowException(ex.Message, ex)')
// del 'Calculate' method.
{
    //Logger.Log(ex.StackTrace); //1st version of Logger
    /*
    No es necesario instanciar 'Logger', pues es 'static'
    En excepción de out-of-range, the Stack Trace information for this excep obj, will be captured in log file.

    Stack Trace -> contains info about files containing our code, and
        the lines of code traversed when the stack unwinds as a result of an exception occurring
    */
    Logger.Log(ex, LogType.Verbose); // call overload method
    /*
    1st arg -> cought ex
    2nd arg -> verbose logging
    */

    WriteExceptionMessageToScreen($"The desired result is our of range for an Integer value (i.e. between {Int32.MinValue} and {Int32.MaxValue}).");
}
catch (OverflowException ex) //Entering out of range values for Int datatypes
{
    Logger.Log(ex, LogType.Verbose);
    WriteExceptionMessageToScreen($"The value for an operand  is out of range (i.e. not between {Int32.MinValue} and {Int32.MaxValue})");
}
catch (BlankUserInputException ex) 
{
    Logger.Log(ex, LogType.Verbose);
    WriteExceptionMessageToScreen("A field was left blank.");
}
// catch (ArithmeticException ex)
// {
//     //Console.Clear(); //Clear Console to display Error Msg
//     Console.WriteLine();
//     Console.BackgroundColor = ConsoleColor.White;
//     Console.ForegroundColor = ConsoleColor.Red;
    
//     Console.WriteLine(ex.Message);
    
//     Console.ResetColor();
// }
catch (FormatException ex)
{
    Logger.Log(ex, LogType.Verbose);
    WriteExceptionMessageToScreen("input value is invalid");
}
catch(ArgumentException ex)
{
    Logger.Log(ex, LogType.Verbose);
    WriteArgumentExceptionToScreen(ex); //eval which param caused the exception and throw its message
}
finally
{
    Console.ResetColor();
    Console.WriteLine("Press any key to exit program...");
}

Console.ReadKey(); //Esperar por user input

/////////////// part 21.5

static char ValidateOperatorInput()
{
    int counter = 1;
    const int maxTries = 5;
    string userInput = null;

    try
    {
        do
        {
            userInput = Console.ReadLine();

            //if user input is a valid char
            if(char.TryParse(userInput, out char c) && c == '+' || c == '-' || c == '/' || c == '*')
            {
                return c;
            }
            else
            {
                WriteAttemptWarningToScreen(counter);
            }
            counter++;

        } while (counter < maxTries);

        userInput = Console.ReadLine();

        CheckBlankUserInput(userInput); // Also validate blank entries
        
        char r = Char.Parse(userInput);

        return r;
        
    }
    catch (BlankUserInputException ex)
    {
        Logger.Log(ex, LogType.Basic);
        throw;
    }
    catch (FormatException ex)
    {
        Logger.Log(ex, LogType.Basic);
        throw;
    }
}


// Let a specific amount of tries on Operand for user input 
static int ValidateOperandInput()
{
    int Counter = 1;
    const int maxTries = 5;
    string userInput = string.Empty; // for user input

    try
    {
        
        do
        {
            userInput = Console.ReadLine();

            //when input is incorrect, increment Counter
            if(int.TryParse(userInput, out int i)) 
            /*
            Converts the string representation of a number to its 32-bit signed integer equivalent. 
                1st arg -> string
                    String? s
                2nd arg -> int output
                    'out' -> allows for the converted interger value to be passed out to the calling method
                    through the relevant parameter.

            Returns true / false -> whether the conversion succeeded.
            'i' can be returned, it's the value now converted to an integer
            */
            {
                return i; // if true, return the valid converted user input 'string' as 'int'
            }
            else
            {
                // write attempt warning to screen
                WriteAttemptWarningToScreen(Counter);
            }
            Counter++;
        }
        while(Counter < maxTries);

        //out here, tue user has had 4 attempts at entering valid data
        //handle exception if input at 5th attempt is invalid

        userInput = Console.ReadLine();

        CheckBlankUserInput(userInput); //catch blank input

        int operand = int.Parse(userInput); //Convert string to int

        return operand;
    }
    catch(BlankUserInputException ex)
    {
        Logger.Log(ex, LogType.Basic); // send it to Logger
        throw; //throw excep up the stack (handled in the main method)
    }
    catch (FormatException ex)
    {
        Logger.Log(ex, LogType.Verbose);
        throw; // throw the exception up the stack
        // So that the Main method can handle the exception

        /* 
        'throws' allows us to throw an existing cougth exception obj up the stack
        without modifying the exception obj.

        For example; when the developer wishes to handle the exception in a
        method and also throw the excep. up the stack to be also handled 
        by a method further up the stack.
        
        */
    }


}

static void WriteAttemptWarningToScreen(int count)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"(You have made {count} attempt{(count == 1? "": "s")})"); //ternary operator
    Console.ResetColor();
    Console.WriteLine("Please try again.");
}
///////////////


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


//integrating custom exception within this method:
static void CheckBlankUserInput(string userInput)
{
    if(String.IsNullOrWhiteSpace(userInput)) //using built-in method IsNullOrWitheSpace from 'String' class
        throw new BlankUserInputException();
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