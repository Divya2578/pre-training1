
using System;
using System.Collections;

// Interface 1 
interface Iclass1
{
    void languages();
}

// Parent class 1 
class ClassA1 : Iclass1 
{

    // Providing the implementation 
    // of languages() method 
    public void languages()
    {

        // Creating ArrayList 
        ArrayList My_list = new ArrayList();

        // Adding elements in the 
        // My_list ArrayList 
        My_list.Add("C");
        My_list.Add("C++");
        My_list.Add("C#");
        My_list.Add("Java");

        Console.WriteLine("Languages provided by ClassAB:");
        foreach (var elements in My_list)
        {
            Console.WriteLine(elements);
        }
    }
}

// Interface 2 
interface Iclass2
{
    void courses();
}

// Parent class 2 
class ClassB2 : Iclass2
{

    // Providing the implementation 
    // of courses() method 
    public void courses()
    {

        // Creating ArrayList 
        ArrayList My_list = new ArrayList();

        // Adding elements in the 
        // My_list ArrayList 
        My_list.Add("System Design");
        My_list.Add("Fork Python");
        My_list.Add("Geeks Classes DSA");
        My_list.Add("Fork Java");

        Console.WriteLine("\nCourses provided by ClassAB:");
        foreach (var elements in My_list)
        {
            Console.WriteLine(elements);
        }
    }
}

// Child class 
class ClassAB : Iclass1, Iclass2
{

    // Creating objects of ClassA! and ClassB2 class 
    ClassA1 obj1 = new ClassA1();
    ClassB2 obj2 = new ClassB2();

    public void languages()
    {
        obj1.languages();
    }

    public void courses()
    {
        obj2.courses();
    }
}

// Driver Class 
public class Program
{

    // Main method 
    static public void Main()
    {

        // Creating object of ClassAB  
        ClassAB obj = new ClassAB ();
        obj.languages();
        obj.courses();
    }
}
