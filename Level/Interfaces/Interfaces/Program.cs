using System;
interface IDrawable
{
    void draw();
}
public class Rectangle : IDrawable
{
    public void draw()
    {
        Console.WriteLine("Drawing rectangle...");
    }
}
public class Circle : IDrawable
{
    public void draw()
    {
        Console.WriteLine("Drawing circle...");
    }
}
public class TestInterface
{
    public static void Main()
    {
        IDrawable d;
        d = new Rectangle();
        d.draw();
        d = new Circle();
        d.draw();

        Rectangle R = new Rectangle();
        R.draw();

        Circle C = new Circle();
        C.draw();
    }
}

