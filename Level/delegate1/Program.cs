using System;
public delegate void HelloDelegate(string Message);
class Program
{
    public static void Main()
    {
        HelloDelegate del = new HelloDelegate(Hello);
        del("Hello from Delegates");
    }

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}