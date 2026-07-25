using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a Shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle();
        Shape rectangle = new Rectangle();

        circle.Draw();
        rectangle.Draw();
    }
}