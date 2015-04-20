/* Problem 1. Shapes
 * Define abstract class Shape with only one abstract method 
   CalculateSurface() and fields width and height.
 * Define two new classes Triangle and Rectangle that implement 
   the virtual method and return the surface of the figure 
   (height * width for rectangle and height * width/2 for triangle).
 * Define class Square and suitable constructor so that 
   at initialization height must be kept equal to width 
   and implement the CalculateSurface() method.
 * Write a program that tests the behaviour of the CalculateSurface() method 
   for different shapes (Square, Rectangle, Triangle) stored in an array.
 */

namespace Shapes
{
    using System;

    class Test
    {
        static void Main()
        {
            Shape[] shapes =
            {
                new Rectangle(3.5, 5.6),
                new Rectangle(2.8, 7.4),
                new Triangle(4.1, 9.7),
                new Triangle(3.0, 2.5),
                new Square(8.6, 8.6),
                new Square(10)
            };

            Console.WriteLine("{0,-15}{1,5}", "Shape", "Area");
            Console.WriteLine(new string('-', 20));
            foreach (var shape in shapes)
            {
                Console.WriteLine("{0,-15}{1,5:F2}", shape.GetType().Name, shape.CalculateSurface());
            }
            Console.WriteLine();
        }
    }
}
