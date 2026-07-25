using System;

class BaseClass
{
    public string PublicMessage = "Public Member";
    private string PrivateMessage = "Private Member";
    protected string ProtectedMessage = "Protected Member";

    public void ShowPrivateMessage()
    {
        Console.WriteLine(PrivateMessage);
    }
}

class DerivedClass : BaseClass
{
    public void DisplayMembers()
    {
        Console.WriteLine(PublicMessage);
        Console.WriteLine(ProtectedMessage);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseClass obj1 = new BaseClass();

        Console.WriteLine("Accessing from Non-Derived Class:");
        Console.WriteLine(obj1.PublicMessage);
        obj1.ShowPrivateMessage();

        DerivedClass obj2 = new DerivedClass();

        Console.WriteLine("\nAccessing from Derived Class:");
        obj2.DisplayMembers();
    }
}