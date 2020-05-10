﻿using System;
using System.Collections.Generic;
using System.Linq;

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

        // Create a Func delegate
        Func<Employee, string> selector =
            employee => "Name = " + employee.Name;
        // Pass the delegate to the Select() LINQ function
        IEnumerable<string> names = listEmployees.Select(selector);

        // The above output can be achieved using
        // lambda expression as shown below
        // IEnumerable<string> names =
        // listEmployees.Select(employee => "Name = " + employee.Name);

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

/*using System;
class Program
{
    public static void Main()
    {
        Func<int, int, string> funcDelegate = (firstNumber, secondNumber) =>
            "Sum = " + (firstNumber + secondNumber).ToString();

        string result = funcDelegate(10, 20);
        Console.WriteLine(result);
    }
}
*/