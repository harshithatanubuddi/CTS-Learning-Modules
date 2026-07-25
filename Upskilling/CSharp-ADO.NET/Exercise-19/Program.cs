using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string>
        {
            "Apple",
            "Banana",
            "Mango"
        };

        fruits.Add("Orange");
        fruits.Remove("Banana");

        Console.WriteLine("List Contents:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "Tarun");
        students.Add(102, "Rahul");
        students.Add(103, "Kiran");

        students.Remove(102);

        Console.WriteLine("\nDictionary Contents:");
        foreach (KeyValuePair<int, string> item in students)
        {
            Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
        }
    }
}