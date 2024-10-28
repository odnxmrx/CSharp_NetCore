using System;
using System.IO; //for StreamWriter

namespace _02_BasicCalculator;

//Indicate how much detail to log to specific exception
public enum LogType
{
    Basic, //indicate min. amount of info in log file
    Verbose // log more detailed info
}

public static class Logger
{
    //take the directory path of our project
    private static readonly string _logPath = AppDomain.CurrentDomain.BaseDirectory; //'_' member variables

    //type streamwriter to append text into txt
    private static StreamWriter _logFile = null;

    public static void Log(string textToLog) //'textLog' text to me logged into txt
    {
        //instancia de obj de tipo StreamWriter
        _logFile = new StreamWriter(_logPath + "basicCalculatorLog.txt", true);
        // 2nd param is Bool: true -> append, false-> overwrite
        // ** Si no existiera, lo crea
        
        _logFile.WriteLine("[" +DateTime.Now.ToString() + "]: " + textToLog); //Log text to txt

        _logFile.Close(); //close file

    }
}
