using System;

class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Tarun", 21);

        person.DisplayInfo();
    }
}