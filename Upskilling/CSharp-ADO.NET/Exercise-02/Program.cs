using System;

class Student
{
    public string Name;
}

class Program
{
    static void ModifyValue(int num)
    {
        num = 100;
    }

    static void ModifyReference(Student student)
    {
        student.Name = "Tarun";
    }

    static void Main(string[] args)
    {
        int number = 10;

        Student s = new Student();
        s.Name = "John";

        Console.WriteLine("Before Method Call:");
        Console.WriteLine("Number = " + number);
        Console.WriteLine("Student Name = " + s.Name);

        ModifyValue(number);
        ModifyReference(s);

        Console.WriteLine("\nAfter Method Call:");
        Console.WriteLine("Number = " + number);
        Console.WriteLine("Student Name = " + s.Name);
    }
}