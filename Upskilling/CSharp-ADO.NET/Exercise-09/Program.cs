using System;

class Program
{
    static int CalculateFactorial(int n)
    {
        int Factorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;

            return num * Factorial(num - 1);
        }

        return Factorial(n);
    }

    static void Main(string[] args)
    {
        int number = 5;

        int result = CalculateFactorial(number);

        Console.WriteLine("Factorial of " + number + " is " + result);
    }
}