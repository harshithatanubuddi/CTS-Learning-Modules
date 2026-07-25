using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalAmount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>
        {
            new Order { OrderId = 101, CustomerName = "Tarun", TotalAmount = 1500 },
            new Order { OrderId = 102, CustomerName = "Rahul", TotalAmount = 800 },
            new Order { OrderId = 103, CustomerName = "Kiran", TotalAmount = 2200 },
            new Order { OrderId = 104, CustomerName = "Sai", TotalAmount = 600 }
        };

        var filteredOrders = orders
            .Where(o => o.TotalAmount > 1000)
            .Select(o => new
            {
                o.OrderId,
                o.CustomerName
            });

        Console.WriteLine("Orders with Total Amount > 1000");

        foreach (var order in filteredOrders)
        {
            Console.WriteLine($"Order ID: {order.OrderId}, Customer: {order.CustomerName}");
        }
    }
}