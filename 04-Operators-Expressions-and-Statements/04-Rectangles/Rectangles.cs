using System;
class Rectangles
{
    static void Main()
    {
        // * Write an expression that calculates rectangle’s perimeter and area by given width and height.

        Console.Write("Width of rectangle: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Height of rectangle: ");
        float height = float.Parse(Console.ReadLine());

        float p = width * 2 + height * 2;
        float s = width * height;

        Console.WriteLine("Perimeter = " + p);
        Console.WriteLine("Area = " + s);
    }
}