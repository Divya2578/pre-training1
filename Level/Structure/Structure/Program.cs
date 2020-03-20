using System;
public struct Rectangle
{
    public int width, height;

    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }
    public void AreaOfRectangle()
    {
        int Area = (width * height);
        Console.WriteLine("Area of Rectangle is: {0}" , Area);
    }
}
public class Program
{
    public static void Main()
    {
        Rectangle r = new Rectangle(5, 6);
        r.AreaOfRectangle();
    }
}
