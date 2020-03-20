using System;
public class Employee
{
    public int id;
    public String name;
    public float salary;
    public void EmployeeDetails(int i, String n, float s)
    {
        id = i;
        name = n;
        salary = s;
    }
    public void PrintDetails()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Employee Details\n");
        Employee e1 = new Employee();
        Employee e2 = new Employee();
        e1.EmployeeDetails(2598, "Divya", 890000f);
        e2.EmployeeDetails(0996, "Mahesh", 490000f);
        e1.PrintDetails();
        e2.PrintDetails();

    }
}
