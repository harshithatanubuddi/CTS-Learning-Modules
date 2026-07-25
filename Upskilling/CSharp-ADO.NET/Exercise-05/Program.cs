using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nUsing if-else:");

        if (score >= 90)
            Console.WriteLine("Grade A");
        else if (score >= 80)
            Console.WriteLine("Grade B");
        else if (score >= 70)
            Console.WriteLine("Grade C");
        else if (score >= 60)
            Console.WriteLine("Grade D");
        else
            Console.WriteLine("Grade F");

        Console.WriteLine("\nUsing switch pattern matching:");

        string grade = score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

        Console.WriteLine("Grade " + grade);
    }
}