using System;
using System.Collections.Generic;
public class Program
{
    private static void Main()
    {
        Calculator.Add(new List<int>() { 10, 20, 40 });
       
    }
}


public class Calculator
{
    [Obsolete]
    public static int Add(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }
    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach (int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
        Console.WriteLine(Sum);
    }
}
