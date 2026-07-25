using System;

class Contact
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Contact? contact1 = new Contact
        {
            Name = "Tarun",
            PhoneNumber = "9876543210"
        };

        Contact? contact2 = null;

        Console.WriteLine("Contact 1 Name: " + (contact1?.Name ?? "Name Not Available"));
        Console.WriteLine("Contact 2 Name: " + (contact2?.Name ?? "Name Not Available"));
    }
}