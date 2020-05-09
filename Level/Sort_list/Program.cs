<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

        Console.WriteLine("Numbers before sorting");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        // Sort() will sort data in ascending order 
        numbers.Sort();

        Console.WriteLine("Numbers after sorting");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        // Use Reverse() method to retrieve data in descending order
        numbers.Reverse();

        Console.WriteLine("Numbers in descending order");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };

        Console.WriteLine("Alphabets before sorting");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        alphabets.Sort();

        Console.WriteLine("Alphabets after sorting");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        alphabets.Reverse();

        Console.WriteLine("Alpabets in descending order");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Mark",
            Salary = 4000
        };

        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "Pam",
            Salary = 7000
        };

        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Rob",
            Salary = 5500
        };

        List<Customer> listCutomers = new List<Customer>();
        listCutomers.Add(customer1);
        listCutomers.Add(customer2);
        listCutomers.Add(customer3);

        Console.WriteLine("Customers before sorting");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        // Sort() method should sort customers by salary
        listCutomers.Sort();

        Console.WriteLine("Customers after sorting");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        // To sort customers by name instead of salary
       // SortByName sortByName = new SortByName();
        //listCutomers.Sort(sortByName);

        Console.WriteLine("Customers after sorting by Name");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }
    }
}

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

}

=======
﻿using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

        Console.WriteLine("Numbers before sorting");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        // Sort() will sort data in ascending order 
        numbers.Sort();

        Console.WriteLine("Numbers after sorting");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        // Use Reverse() method to retrieve data in descending order
        numbers.Reverse();

        Console.WriteLine("Numbers in descending order");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };

        Console.WriteLine("Alphabets before sorting");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        alphabets.Sort();

        Console.WriteLine("Alphabets after sorting");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        alphabets.Reverse();

        Console.WriteLine("Alpabets in descending order");
        foreach (string alphabet in alphabets)
        {
            Console.WriteLine(alphabet);
        }

        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Mark",
            Salary = 4000
        };

        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "Pam",
            Salary = 7000
        };

        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Rob",
            Salary = 5500
        };

        List<Customer> listCutomers = new List<Customer>();
        listCutomers.Add(customer1);
        listCutomers.Add(customer2);
        listCutomers.Add(customer3);

        Console.WriteLine("Customers before sorting");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        // Sort() method should sort customers by salary
        listCutomers.Sort();

        Console.WriteLine("Customers after sorting");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        // To sort customers by name instead of salary
       // SortByName sortByName = new SortByName();
        //listCutomers.Sort(sortByName);

        Console.WriteLine("Customers after sorting by Name");
        foreach (Customer customer in listCutomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }
    }
}

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

}

>>>>>>> 3a2589c16a379f05e76bc0b76955d6a3b62be7a7
