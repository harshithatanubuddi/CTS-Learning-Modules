using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        User user = new User
        {
            Name = "Tarun",
            Age = 21,
            Email = "tarun@example.com"
        };

        string jsonString = JsonSerializer.Serialize(user, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText("user.json", jsonString);

        Console.WriteLine("User object serialized and saved to user.json");

        string jsonFromFile = File.ReadAllText("user.json");

        User deserializedUser = JsonSerializer.Deserialize<User>(jsonFromFile);

        Console.WriteLine("\nDeserialized User Details:");
        Console.WriteLine($"Name  : {deserializedUser.Name}");
        Console.WriteLine($"Age   : {deserializedUser.Age}");
        Console.WriteLine($"Email : {deserializedUser.Email}");
    }
}