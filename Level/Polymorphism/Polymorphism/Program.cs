//Concept of method hiding 
using System;

// Base Class 
public class My_Family
{

    public virtual void PrintMember()
    {
        Console.WriteLine("Total number of family members: 3");
    }
}

// Derived Class 
public class My_Member : My_Family
{

    // Reimplement the method of the base class 
    // Using new keyword 
    // It hides the method of the base class 
    public override void PrintMember()
    {
        Console.WriteLine("Name: Balkrishna, Age: 45 \nName: Lalita, " +
                               "Age: 43 \nName: Divya, Age: 20 ");
    }
}

// Driver Class 
class Program
{

    // Main method 
    static public void Main()
    {

        // Creating the object of the derived class 
        My_Member M1 = new My_Member();

        // Access the method of derived class 
        M1.PrintMember();

        // Acces the method of Parent class
        My_Family M2 = new My_Member();
        M2.PrintMember();

        //Access the method of parent class
        ((My_Family)M2).PrintMember();
    }
}
