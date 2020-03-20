using System;
class Program
{
    static void Main(string[] args)
    {
        string value = "275t";
        int r = 0;
        bool IsConversionSuccessfull = int.TryParse(value, out r);

        if (IsConversionSuccessfull)
        {

            Console.WriteLine(r);
        }
        else
        {
            Console.WriteLine("Please enter the correct number  " );
        }
        Console.ReadKey();
    }

}
