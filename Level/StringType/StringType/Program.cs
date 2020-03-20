using System;

    class Program
    {
        public static void Main()
        {
           
            string Name = "\"Divya\"";
            Console.WriteLine(Name);

           
            Name = "One\nTwo\nThree";
            Console.WriteLine(Name);

            // Displaying new line character in c#
            Name = "c:\\Tadooru\\Divya\\Balkrishna\\Renuka";
            Console.WriteLine(Name);

            // C# verbatim literal
            Name = @"c:\Tadooru\Divya\Balkrishna\Renuka";
            Console.WriteLine(Name);
        }
    }


