using System;
using System.Threading;

class Program
{
    private static Mutex mutexA = new Mutex();
    private static Mutex mutexB = new Mutex();
    private static Mutex mutexC = new Mutex();

    static void Main()
    {
        Thread threadA = new Thread(PrintA);
        Thread threadB = new Thread(PrintB);
        Thread threadC = new Thread(PrintC);

        threadA.Start();
        threadB.Start();
        threadC.Start();

        threadA.Join();
        threadB.Join();
        threadC.Join();

    }
    static void PrintC()
    {
        for (int i = 0; i < 5; i++)
        {
            mutexA.WaitOne();
            Console.WriteLine("C");
            mutexA.ReleaseMutex();
        }
    }
    static void PrintA()
    {
        for (int i = 0; i < 5; i++)
        {
            mutexA.WaitOne();
            Console.WriteLine("A");
            mutexA.ReleaseMutex();
        }
    }

    static void PrintB()
    {
        for (int i = 0; i < 5; i++)
        {
            mutexA.WaitOne();
            Console.WriteLine("B");
            mutexA.ReleaseMutex();
        }
    }

   
}
