<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Mahesh",
            Gender = "Male"
        };

        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "Paresh",
            Gender = "Female"
        };

        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Jigar",
            Gender = "Male"
        };

        Customer customer4 = new Customer()
        {
            ID = 104,
            Name = "Kreeti",
            Gender = "Female"
        };

        Customer customer5 = new Customer()
        {
            ID = 105,
            Name = "Vanita",
            Gender = "Female"
        };

        // Create a Queue
        Queue<Customer> queueCustomers = new Queue<Customer>();
        // To add an item to the queue, use Enqueue() method.



        queueCustomers.Enqueue(customer1);
        queueCustomers.Enqueue(customer2);
        queueCustomers.Enqueue(customer3);
        queueCustomers.Enqueue(customer4);
        queueCustomers.Enqueue(customer5);

        // To retrieve an item from the queue, use Dequeue() method. 
      
        Customer c1 = queueCustomers.Dequeue();
        Console.WriteLine(c1.ID + " -  " + c1.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

        Customer c2 = queueCustomers.Dequeue();
        Console.WriteLine(c2.ID + " -  " + c2.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

        Customer c3 = queueCustomers.Dequeue();
        Console.WriteLine(c3.ID + " -  " + c3.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

        Customer c4 = queueCustomers.Dequeue();
        Console.WriteLine(c4.ID + " -  " + c4.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

        Customer c5 = queueCustomers.Dequeue();
        Console.WriteLine(c5.ID + " -  " + c5.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
        Console.WriteLine("-----------------------------------------------------------");

        // After customer5 is dequeued, there will be no items left in the 
        // queue. So, let's enqueue the five objects once again
        queueCustomers.Enqueue(customer1);
        queueCustomers.Enqueue(customer2);
        queueCustomers.Enqueue(customer3);
        queueCustomers.Enqueue(customer4);
        queueCustomers.Enqueue(customer5);

        // If you need to loop thru items in the queue, foreach loop can be used in the 
        // same way as we use it with other collection classes. The foreach loop will
        // only iterate thru items in the queue, but will not dequeue them.
        foreach (Customer customer in queueCustomers)
        {
            Console.WriteLine(customer.ID + " -  " + customer.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
        }
        Console.WriteLine("-----------------------------------------------------------");

        // To retrieve an item that is present at the beginning of the 
        // queue, without removing it use Peek() method.
        Customer c = queueCustomers.Peek();
        Console.WriteLine(c.ID + " -  " + c.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
        Console.WriteLine("-----------------------------------------------------------");

        // To check if an item, exists in the queue, use Contains() method.
        if (queueCustomers.Contains(customer1))
        {
            Console.WriteLine("customer1 is in Queue");
        }
        else
        {
            Console.WriteLine("customer1 is not in Queue");
        }
    }
}

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
=======
﻿using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer()
        {
            ID = 101,
            Name = "Mahesh",
            Gender = "Male"
        };

        Customer customer2 = new Customer()
        {
            ID = 102,
            Name = "Paresh",
            Gender = "Female"
        };

        Customer customer3 = new Customer()
        {
            ID = 103,
            Name = "Jigar",
            Gender = "Male"
        };

        Customer customer4 = new Customer()
        {
            ID = 104,
            Name = "Kreeti",
            Gender = "Female"
        };

        Customer customer5 = new Customer()
        {
            ID = 105,
            Name = "Vanita",
            Gender = "Female"
        };

        // Create a Queue
        Queue<Customer> queueCustomers = new Queue<Customer>();
        // To add an item to the queue, use Enqueue() method.



        queueCustomers.Enqueue(customer1);
        queueCustomers.Enqueue(customer2);
        queueCustomers.Enqueue(customer3);
        queueCustomers.Enqueue(customer4);
        queueCustomers.Enqueue(customer5);

        // To retrieve an item from the queue, use Dequeue() method. 
      
        Customer c1 = queueCustomers.Dequeue();
        Console.WriteLine(c1.ID + " -  " + c1.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

        Customer c2 = queueCustomers.Dequeue();
        Console.WriteLine(c2.ID + " -  " + c2.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

        Customer c3 = queueCustomers.Dequeue();
        Console.WriteLine(c3.ID + " -  " + c3.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

        Customer c4 = queueCustomers.Dequeue();
        Console.WriteLine(c4.ID + " -  " + c4.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

        Customer c5 = queueCustomers.Dequeue();
        Console.WriteLine(c5.ID + " -  " + c5.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
        Console.WriteLine("-----------------------------------------------------------");

        // After customer5 is dequeued, there will be no items left in the 
        // queue. So, let's enqueue the five objects once again
        queueCustomers.Enqueue(customer1);
        queueCustomers.Enqueue(customer2);
        queueCustomers.Enqueue(customer3);
        queueCustomers.Enqueue(customer4);
        queueCustomers.Enqueue(customer5);

        // If you need to loop thru items in the queue, foreach loop can be used in the 
        // same way as we use it with other collection classes. The foreach loop will
        // only iterate thru items in the queue, but will not dequeue them.
        foreach (Customer customer in queueCustomers)
        {
            Console.WriteLine(customer.ID + " -  " + customer.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
        }
        Console.WriteLine("-----------------------------------------------------------");

        // To retrieve an item that is present at the beginning of the 
        // queue, without removing it use Peek() method.
        Customer c = queueCustomers.Peek();
        Console.WriteLine(c.ID + " -  " + c.Name);
        Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
        Console.WriteLine("-----------------------------------------------------------");

        // To check if an item, exists in the queue, use Contains() method.
        if (queueCustomers.Contains(customer1))
        {
            Console.WriteLine("customer1 is in Queue");
        }
        else
        {
            Console.WriteLine("customer1 is not in Queue");
        }
    }
}

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
>>>>>>> 3a2589c16a379f05e76bc0b76955d6a3b62be7a7
}