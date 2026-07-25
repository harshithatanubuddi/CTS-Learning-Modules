using System;

class Person
{
    public string? Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Person? person1 = new Person
        {
            Name = "Tarun"
        };

        Person? person2 = null;

        Console.WriteLine("Person 1 Name: " + (person1?.Name ?? "Name Not Available"));
        Console.WriteLine("Person 2 Name: " + (person2?.Name ?? "Name Not Available"));

        if (person1 != null)
        {
            Console.WriteLine("Person 1 object exists.");
        }

        if (person2 == null)
        {
            Console.WriteLine("Person 2 object is null.");
        }
    }
}