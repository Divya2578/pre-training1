using System;
public class Employee
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.Name = "Divya Tadooru";
        Console.WriteLine("Employee Name: {0}\n", e1.Name);

    }
}
