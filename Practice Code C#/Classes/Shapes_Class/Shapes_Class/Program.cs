using System;

namespace Shapes_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] someShapes = new Shape[3];

            someShapes[0] = new Circle(5.0);
            someShapes[1] = new Rectangle(5.0, 6.0);
            someShapes[2] = new Triangle(5.0, 5.0, 6.0);

            foreach (Shape s in someShapes)
                Console.WriteLine("{0,-16} area is {1:f3}", s, s.GetArea());
            foreach (Shape s in someShapes)
                Console.WriteLine("{0,-16} perimeter is {1:f3}", s, s.GetPerimeter());
        }
    }
}