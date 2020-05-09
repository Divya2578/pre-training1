using System;
using System.Text;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Example of String");
        string userString = "C#";
        userString += " Video";
        userString += " Tutorial";
        userString += " for";
        userString += " beginners";
        Console.WriteLine(userString);

        Console.WriteLine("\n");

        Console.WriteLine("Example of StringBuilder");
        StringBuilder userStringBuilder = new StringBuilder("C#");
        userStringBuilder.Append(" Video");
        userStringBuilder.Append(" Tutorial");
        userStringBuilder.Append(" for");
        userStringBuilder.Append(" beginners");
        Console.WriteLine(userStringBuilder.ToString());
    }
}
