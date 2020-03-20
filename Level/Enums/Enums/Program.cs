using System;
public class EnumExample
{
    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    public static void Main()
    {

        Console.WriteLine("Days\n");
        foreach (Days d in Enum.GetValues(typeof(Days)))
        {
            Console.WriteLine(d);
        }
    }
}
