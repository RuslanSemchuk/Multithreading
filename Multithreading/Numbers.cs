//using System;
//using System.Threading;

//class Numbers
//{
//    private static Semaphore evenSemaphore = new Semaphore(1, 1);
//    private static Semaphore oddSemaphore = new Semaphore(0, 1);

//    static void Main()
//    {
//        Thread evenThread = new Thread(PrintEvenNumbers);
//        Thread oddThread = new Thread(PrintOddNumbers);

//        evenThread.Start();
//        oddThread.Start();

//        evenThread.Join();
//        oddThread.Join();

//    }

//    static void PrintEvenNumbers()
//    {
//        for (int i = 2; i <= 10; i += 2)
//        {
//            evenSemaphore.WaitOne();
//            Console.WriteLine(i);
//            Thread.Sleep(1000);
//            oddSemaphore.Release();
//        }
//    }

//    static void PrintOddNumbers()
//    {
//        for (int i = 1; i <= 9; i += 2)
//        {
//            oddSemaphore.WaitOne();
//            Console.WriteLine(i);
//            Thread.Sleep(1000);
//            evenSemaphore.Release();
//        }
//    }
//}
