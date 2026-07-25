using System;

class Program
{
    static int CalculateTotal(int a, int b)
    {
        return a + b;
    }

    static double CalculateTotal(double a, double b, double c)
    {
        return a + b + c;
    }

    static void Main(string[] args)
    {
        int total1 = CalculateTotal(10, 20);
        double total2 = CalculateTotal(10.5, 20.5, 30.5);

        Console.WriteLine("Sum of two integers: " + total1);
        Console.WriteLine("Sum of three doubles: " + total2);
    }
}