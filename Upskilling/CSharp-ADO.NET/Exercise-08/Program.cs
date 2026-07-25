using System;

class Program
{
    static void ModifyRef(ref int number)
    {
        number += 10;
    }

    static void GetOutValue(out int number)
    {
        number = 50;
    }

    static void DisplayInValue(in int number)
    {
        Console.WriteLine("Value inside in method: " + number);
    }

    static void Main(string[] args)
    {
        int a = 20;

        Console.WriteLine("Before ref call: " + a);
        ModifyRef(ref a);
        Console.WriteLine("After ref call: " + a);

        int b;
        GetOutValue(out b);
        Console.WriteLine("Value from out parameter: " + b);

        int c = 100;
        DisplayInValue(in c);
        Console.WriteLine("Value after in call: " + c);
    }
}