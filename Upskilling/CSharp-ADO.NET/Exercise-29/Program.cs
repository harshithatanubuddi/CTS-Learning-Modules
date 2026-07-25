using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your message: ");
        string userInput = Console.ReadLine();

        string sanitizedInput = WebUtility.HtmlEncode(userInput);

        Console.WriteLine("\nOriginal Input:");
        Console.WriteLine(userInput);

        Console.WriteLine("\nSanitized Input:");
        Console.WriteLine(sanitizedInput);
    }
}