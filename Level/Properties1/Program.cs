using System;

public class student
{
    private int id;
    private string Name;
    private int PassMarks = 35;
    public int GetMark()
    {
        return this.PassMarks;
    }
    public void SetId(int Id)
    {
        if(Id<=0)
        {
            throw new Exception("Student ID cannot be negative");

        }
        this.id = Id;
    }
    public int GetId()
    {
        return this.id;
    }
    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be blank");
        }
        this.Name = name;

    }
    public string GetName()
    {

        if (string.IsNullOrEmpty(this.Name))
        {
            return "No Name";
        }
        else
        {
            return this.Name;
        }
    }
}
public class Program
{
    public static void Main()
    {
        student c1 = new student();
        c1.SetId(01);
      
        c1.SetName("Rahul");
      

        Console.WriteLine("Student Id = {0}", c1.GetId());

        Console.WriteLine("Student Name = {0}", c1.GetName());

        Console.WriteLine("Student Id = {0}", c1.GetMark());
    }
}