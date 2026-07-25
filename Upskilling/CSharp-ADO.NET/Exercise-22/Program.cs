using System;

class Program
{
    static (int, string) GetStudentDetails()
    {
        return (101, "Tarun");
    }

    static void Main(string[] args)
    {
        (int id, string name) = GetStudentDetails();

        Console.WriteLine("Student Details");
        Console.WriteLine($"ID   : {id}");
        Console.WriteLine($"Name : {name}");
    }
}