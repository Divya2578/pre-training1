using System;
public class Cal
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static int add(int a, int b, int c)
    {
        return a + b + c;
    }
    public static float sub(float a, float b)
    {
        return a - b;
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Addition of two numbers = {0} \n",Cal.add(12, 23));
        Console.WriteLine("Addition of three numbers = {0}\n",Cal.add(12, 23, 25));
        Console.WriteLine("Subtraction of two numbers = {0}\n ",Cal.sub(29.5f, 23.5f));
    }
}
