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
    }
  
}
