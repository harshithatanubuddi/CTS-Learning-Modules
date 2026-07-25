using System;
using System.Threading;

class Program
{
    static readonly object lock1 = new object();
    static readonly object lock2 = new object();

    static void Thread1()
    {
        bool acquiredLock1 = false;
        bool acquiredLock2 = false;

        try
        {
            acquiredLock1 = Monitor.TryEnter(lock1, 1000);

            if (acquiredLock1)
            {
                Console.WriteLine("Thread 1 acquired Lock 1");

                Thread.Sleep(500);

                acquiredLock2 = Monitor.TryEnter(lock2, 1000);

                if (acquiredLock2)
                {
                    Console.WriteLine("Thread 1 acquired Lock 2");
                }
                else
                {
                    Console.WriteLine("Thread 1 could not acquire Lock 2");
                }
            }
        }
        finally
        {
            if (acquiredLock2)
                Monitor.Exit(lock2);

            if (acquiredLock1)
                Monitor.Exit(lock1);
        }
    }

    static void Thread2()
    {
        bool acquiredLock2 = false;
        bool acquiredLock1 = false;

        try
        {
            acquiredLock2 = Monitor.TryEnter(lock2, 1000);

            if (acquiredLock2)
            {
                Console.WriteLine("Thread 2 acquired Lock 2");

                Thread.Sleep(500);

                acquiredLock1 = Monitor.TryEnter(lock1, 1000);

                if (acquiredLock1)
                {
                    Console.WriteLine("Thread 2 acquired Lock 1");
                }
                else
                {
                    Console.WriteLine("Thread 2 could not acquire Lock 1");
                }
            }
        }
        finally
        {
            if (acquiredLock1)
                Monitor.Exit(lock1);

            if (acquiredLock2)
                Monitor.Exit(lock2);
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(Thread1);
        Thread t2 = new Thread(Thread2);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Deadlock avoided using Monitor.TryEnter.");
    }
}