using System;
using System.Threading;
namespace ThreadStartDelegateExample
{
    class Program
    {
        public static void Main()
        {
            Thread T1 = new Thread(Number.PrintNumbers);
            T1.Start();
        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

