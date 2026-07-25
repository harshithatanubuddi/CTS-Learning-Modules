using System;

public record Employee
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Department { get; init; }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee
        {
            Id = 101,
            Name = "Tarun",
            Department = "AI & ML"
        };

        Employee emp2 = emp1 with
        {
            Department = "Data Science"
        };

        Console.WriteLine("Original Employee:");
        Console.WriteLine($"ID: {emp1.Id}");
        Console.WriteLine($"Name: {emp1.Name}");
        Console.WriteLine($"Department: {emp1.Department}");

        Console.WriteLine();

        Console.WriteLine("Modified Employee:");
        Console.WriteLine($"ID: {emp2.Id}");
        Console.WriteLine($"Name: {emp2.Name}");
        Console.WriteLine($"Department: {emp2.Department}");
    }
}