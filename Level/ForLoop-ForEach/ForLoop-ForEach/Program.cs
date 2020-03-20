using System;

class Program
{
    static void Main()
    {
        int[] Numbers = { 10, 20, 30 };
        for (int i = 0; i < Numbers.Length; i++)
        {
            Console.WriteLine(Numbers[i]);
        }


        foreach (int j in Numbers)
        {
            Console.WriteLine(j);
        }
        Console.WriteLine("Print even numbers till 20:\n");
        for (int k = 0; k <= 20; k++)
        {
            if (k % 2 == 1)
            {
                continue;
            }
            Console.WriteLine(k);
        }

    }
}