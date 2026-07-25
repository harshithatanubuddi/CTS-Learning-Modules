using System;
using System.Diagnostics;

class Logger
{
    public static void Log(string message)
    {
        Console.WriteLine(message);
        Trace.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
        Trace.AutoFlush = true;

        Logger.Log("Application Started");
        Logger.Log("Processing Data");
        Logger.Log("Application Ended");

        Console.WriteLine("\nLogs have been written to log.txt");

        Trace.Close();
    }
}