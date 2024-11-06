using System;
using System.Runtime.Serialization;

namespace _02_BasicCalculator;

[Serializable] //requiered to make an exception class serializable
public class BlankUserInputException : Exception
{
    public BlankUserInputException()
    {

    }

    //making sure the args. passed to our constructors, are passed down to the base class
    // that's why we need ':base()' with appropiate params. separated by commas.
    public BlankUserInputException(string? message):base(message)
    {

    }

    public BlankUserInputException(string? message, Exception? innerException):base(message, innerException)
    {

    }

    public BlankUserInputException(SerializationInfo info, StreamingContext context):base(info, context)
    {
        /*
        Serializable object?
            Serialization -> process of converting an object into a stream of bytes
            to store the obj., or transmit it to memory, DB, or file.
        */
    }


}
