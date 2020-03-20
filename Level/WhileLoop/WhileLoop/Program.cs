using System;

namespace WhileLoop
{
    class Program
    {
        public static void Main()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            While();
        }
    
        public static void While()
        {

            Console.WriteLine("Enter a Number");
            int Number = int.Parse(Console.ReadLine());
            int start = 0;
            while (start <= Number)
            {
                Console.Write(start + " ");
                start += 2;
            }
        }
    }
}

