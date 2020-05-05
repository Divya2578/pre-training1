using System;

public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}
public class ParttimeEmployee : Employee
{
    public new void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName  + "  Part Time Employee");
    }
}
public class FulltimeEmployee: Employee
{

}

    class Program
    {
        static void Main()
        {
        FulltimeEmployee fte = new FulltimeEmployee();
        fte.FirstName = "Diya";
        fte.LastName = "Tadooru";
        fte.PrintFullName();

        ParttimeEmployee pte = new ParttimeEmployee();
        pte.FirstName = "Lali";
        pte.LastName = "Tadooru";
        pte.PrintFullName();
            
        }
    }

