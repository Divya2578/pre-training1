using System;
class Program
{
    public static void AddNumbers(int firstNumber, int secondNumber,
       int[] restOfNumbers)
    {
        int result = firstNumber + secondNumber;
        if (restOfNumbers != null)
        {
            foreach (int i in restOfNumbers)
            {
                result += i;
            }
        }

        Console.WriteLine("Sum = " + result);
    }
    public static void Main()
    {
        AddNumbers(10, 20, new int[] { 30, 40 });
        Test(1, c:2);
    }
    public static void Test(int a, int b = 10, int c = 20)
    {
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
    }
  


}
