<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 3a2589c16a379f05e76bc0b76955d6a3b62be7a7
}