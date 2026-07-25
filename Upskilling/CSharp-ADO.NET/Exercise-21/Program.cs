using System;

class Program
{
    static void DisplayInfo(object obj)
    {
        if (obj is int number)
        {
            Console.WriteLine($"Integer Value: {number}");
        }
        else if (obj is string text)
        {
            Console.WriteLine($"String Value: {text}");
        }

        string result = obj switch
        {
            int n => $"Square of Number: {n * n}",
            string s => $"String Length: {s.Length}",
            double d => $"Double Value: {d}",
            _ => "Unknown Type"
        };

        Console.WriteLine(result);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        DisplayInfo(10);
        DisplayInfo("Hello");
        DisplayInfo(25.5);
    }
}