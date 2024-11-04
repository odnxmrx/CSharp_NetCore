using System;
using System.IO;
using System.Security.Cryptography.X509Certificates; //for StreamWriter

namespace _02_BasicCalculator;

//Indicate how much detail to log to specific exception
public enum LogType // to indicate how much detail to be logged
{
    Basic, //indicate min. amount of info in log file
    Verbose // log more detailed info
}

public static class Logger
{
    //take the directory path of our project
    private static readonly string _logPath = AppDomain.CurrentDomain.BaseDirectory; //'_' member variables

    //type streamwriter to append text into txt
    private static StreamWriter _logFile = null; // member of System.IO

    public static void Log(string textToLog) //'textLog' text to me logged into txt
    {
        try
        {
            //Make loge file read-only
            // FileInfo fi = new FileInfo(_logPath + "basicCalculatorLog.txt");
            // fi.IsReadOnly = false; //true;

            //instancia de obj de tipo StreamWriter
            _logFile = new StreamWriter(_logPath + "basicCalculatorLog.txt", true);
            // 2nd param is Bool: true -> append, false-> overwrite
            // ** if file no existiera, StreamWriter Class lo crea
            
            _logFile.WriteLine("[" +DateTime.Now.ToString() + "]: " + textToLog); //Log text to txt
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Warning: " +  ex.Message); // access denied message
            Console.ResetColor();
        }
        finally
        {
            _logFile?.Close(); //MUST close file
            // '?' -> Prevent the null reference ex 
        }

    }
    
    //overload method
    public static void Log(Exception ex, LogType logtype) // Log ex on file depending on LogType enum:
    { 
        try
        {
            _logFile = new StreamWriter(_logPath + "basicCalculatorLog.txt", true);

            //Evaluate value passed into LogType param
            if(logtype == LogType.Basic)
            {
                _logFile.WriteLine($"[{DateTime.Now}]:, Exception Name: ${ex.GetType().Name} - Exception Message: {ex.Message}");
            }
            else if(logtype == LogType.Verbose)
            {
                _logFile.WriteLine($"[{DateTime.Now}]:, Exception Name: ${ex.GetType().Name} - Exception Message: {ex.Message}, InnerException Message: {ex.InnerException?.Message} - Stack Trace: {ex.StackTrace}");

                if(ex is ArgumentException) //ALSO log param name of the arg causing the Ex
                {
                    _logFile.Write($", ParamName: {((ArgumentException)ex).ParamName}");
                }
            }
        }
        catch (UnauthorizedAccessException exeption)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Warning: " +  exeption.Message); // access denied message
            Console.ResetColor();
        }
        finally
        {
            _logFile?.Close(); //MUST close file, so text is written
        }
    }
}
