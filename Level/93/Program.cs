using System;
using System.Threading;
class Program
{
    static int Total = 0;
    public static void Main()
    {
       // Stopwatch stopwatch = Stopwatch.StartNew();
        Thread thread1 = new Thread(Program.AddOneMillion);
        Thread thread2 = new Thread(Program.AddOneMillion);
        Thread thread3 = new Thread(Program.AddOneMillion);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Total = " + Total);
    }

   /* public static void AddOneMillion()
    {
        for (int i = 1; i <= 1000000; i++)
        {
            Total++;
        }
    }*/

   /* public static void AddOneMillion()
    {
        for (int i = 1; i <= 1000000; i++)
        {
            Interlocked.Increment(ref Total);
        }
    }*/

    static object _lock = new object();

public static void AddOneMillion()
{
    for (int i = 1; i <= 1000000; i++)
    {
        lock (_lock)
        {
            Total++;
        }
    }
}

   /* stopwatch.Stop();
    Console.WriteLine("Time Taken in Ticks = " + stopwatch.ElapsedTicks);*/
}


