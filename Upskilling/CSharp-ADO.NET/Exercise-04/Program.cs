using System;

class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var number = 100;
        var message = "Hello C#";

        Student student = new("Tarun");

        Console.WriteLine("Value: " + number);
        Console.WriteLine("Type : " + number.GetType());

        Console.WriteLine();

        Console.WriteLine("Value: " + message);
        Console.WriteLine("Type : " + message.GetType());

        Console.WriteLine();

        Console.WriteLine("Student Name: " + student.Name);
        Console.WriteLine("Type : " + student.GetType());
    }
}