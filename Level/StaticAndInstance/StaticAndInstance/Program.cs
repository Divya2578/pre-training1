using System;

namespace StaticAndInstance
{
    class Circle 
    {
        float Pi = 3.14f;
        int radius;
        public Circle(int Radius)
        {
            this.radius = Radius;
        }
        public float CalculateArea()
        {
            return this.Pi * this.radius * this.radius;
        }
    }
    class Cube
    {
        public static int cube(int n)
        { return n * n * n; }
    }

    class Program
    {
        static void Main()
        {
            Circle c1 = new Circle(5);
            float Area = c1.CalculateArea();
            Console.WriteLine("Area of the Circle = {0}", Area);

            int AreaofCube = Cube.cube(3);
            Console.WriteLine("Area of the Cube {0}", AreaofCube);


        }
    }
}
