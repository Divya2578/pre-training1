using System;
    public class MainClass
    {
        private static void Main()
        {
            bool Equal = Calculator.AreEqual<int>(10,10);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

