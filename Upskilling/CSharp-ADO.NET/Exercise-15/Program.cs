using System;

abstract class Vehicle
{
    public abstract void Drive();
}

interface IDrivable
{
    void Start();
}

class Car : Vehicle, IDrivable
{
    public override void Drive()
    {
        Console.WriteLine("Car is being driven.");
    }

    public void Start()
    {
        Console.WriteLine("Car has started.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Car();
        vehicle.Drive();

        IDrivable drivable = new Car();
        drivable.Start();
    }
}