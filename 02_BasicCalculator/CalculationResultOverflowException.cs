using System;

namespace _02_BasicCalculator;

//custom exception handling
public class CalculationResultOverflowException : OverflowException
{
    public CalculationResultOverflowException() //CTOR
    {
    }

    //Initializes a new instance of the System.OverflowException class with a specified
    //error message :
    public CalculationResultOverflowException(string? message):base(message)
    {
        //there's no requirement to write code here; we simply pass the 'message' arg to the 'base' class
        /*
        meaning -> calling code can pass a string 'message' as arg.
        to this CTOR when the 'Calculate result overflow exception object' is being constructed. 
        Passing the message arg. down to the base clase.
        */
    }

    //CTOR where 'message' and the original exception object can be passed as args. ('OverflowException')
    public CalculationResultOverflowException(string? message, Exception innerException):base(message, innerException)
    {
    }
}
