using System;
public class Employee
{
    public Employee()
    {
        Console.WriteLine("Constructor Invoked");
    }
    ~Employee()
    {
        Console.WriteLine("Destructor Invoked");
    }
}
class Program
{
    public static void Main()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();
    }
}
