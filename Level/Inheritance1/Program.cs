using System;
using System.Reflection.PortableExecutable;

public class Employee
{
   public string FirstName;
    public string LastName;
    public string Email;

    public void PrintfullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " " + Email);
    }
}
public class FulltimeEmployee : Employee {
    public float Yearlysalary;
}

public class ParttimeEmployee : Employee
{
    public float HourlyRate ;
}
public class Program
{
    public static void Main()
    {
        FulltimeEmployee fte = new FulltimeEmployee();
        fte.FirstName = "Divya";
        fte.LastName = "Tadooru";
        fte.Yearlysalary = 25000;
        fte.Email = "divyatadooru78@gmail.com";
        fte.PrintfullName();

        ParttimeEmployee pte = new ParttimeEmployee();
        pte.FirstName = "Mahesh";
        pte.LastName = "Tadooru";
        pte.HourlyRate = 5000;
        pte.Email = "maheshtadooru@gmail.com";
        pte.PrintfullName();
    }
}