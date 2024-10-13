using System;

namespace _02_BasicCalculator;

//custom exception handling
public class CalculationResultOverflowException : OverflowException
{
    public CalculationResultOverflowException() //CTOR
    {
        
    }
}
