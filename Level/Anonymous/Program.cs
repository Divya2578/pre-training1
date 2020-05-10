using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<Employee> listEmployees = new List<Employee>()
        {
            new Employee{ ID = 101, Name = "Mark"},
            new Employee{ ID = 102, Name = "John"},
            new Employee{ ID = 103, Name = "Mary"},
        };

        // Step 2
        Predicate<Employee> predicateEmployee =
            new Predicate<Employee>(FindEmployee);

        // Step 3
        Employee employee =
            listEmployees.Find(x => predicateEmployee(x));
        Console.WriteLine("ID = {0}, Name {1}",
            employee.ID, employee.Name);

        
        employee = listEmployees.Find(delegate (Employee x)
        { return x.ID == 102; });
        Console.WriteLine("ID = {0}, Name {1}",
            employee.ID, employee.Name);
    }

    // Step 1
    private static bool FindEmployee(Employee Emp)
    {
        return Emp.ID == 102;
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
