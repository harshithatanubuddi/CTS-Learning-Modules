using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "sample.txt";

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);

            string content = Encoding.UTF8.GetString(buffer);

            Console.WriteLine("Contents of sample.txt:");
            Console.WriteLine(content);
        }

        using (MemoryStream ms = new MemoryStream())
        {
            string message = "Welcome to ADO.NET";
            byte[] data = Encoding.UTF8.GetBytes(message);

            ms.Write(data, 0, data.Length);

            Console.WriteLine("\nMemoryStream Information:");
            Console.WriteLine($"Bytes Written: {ms.Length}");
        }
    }
}