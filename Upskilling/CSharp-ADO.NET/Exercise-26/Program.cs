using System;
using System.Threading;

class Program
{
    static int counter = 0;
    static readonly object lockObject = new object();

    static void IncrementCounter()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (lockObject)
            {
                counter++;
            }
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(IncrementCounter);
        Thread t2 = new Thread(IncrementCounter);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Counter Value: " + counter);
    }
}