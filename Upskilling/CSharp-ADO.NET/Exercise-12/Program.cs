using System;

class Product
{
    public string Name { get; set; }

    private double price;

    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                Console.WriteLine("Price cannot be negative.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product();

        product.Name = "Laptop";
        product.Price = 50000;

        Console.WriteLine("Product Details:");
        Console.WriteLine($"Name  : {product.Name}");
        Console.WriteLine($"Price : {product.Price}");

        Console.WriteLine("\nTrying to assign a negative price...");
        product.Price = -1000;

        Console.WriteLine($"Final Price : {product.Price}");
    }
}