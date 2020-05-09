using System;


public delegate void addnum(int a, int b);
public delegate void subnum(int a, int b);
class Program
{
    public static void Main(String[] args)
    {

        Program p = new Program();

        addnum del1 = new addnum(p.sum);
        subnum del2 = new subnum(p.subtract);

        // pass the values to the methods by delegate object 
        del1(100, 40);
        del2(100, 60);

    }
    public void sum(int a, int b)
    {
        Console.WriteLine("(100 + 40) = {0}", a + b);
    }


    public void subtract(int a, int b)
    {
        Console.WriteLine("(100 - 60) = {0}", a - b);
    }
}

