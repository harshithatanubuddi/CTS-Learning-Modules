using System;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car()
    {
        Make = "Toyota";
        Model = "Corolla";
        Year = 2020;
    }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void Display()
    {
        Console.WriteLine($"Make : {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year : {Year}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();

        Car car2 = new Car("Honda", "City", 2024);

        Console.WriteLine("Car Created Using Default Constructor");
        car1.Display();

        Console.WriteLine("Car Created Using Parameterized Constructor");
        car2.Display();
    }
}