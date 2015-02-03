using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        // * Write a program that reads the radius r of a circle and prints 
        //   its perimeter and area formatted with 2 digits after the decimal point.

        Console.Write("r = ");
        float r = float.Parse(Console.ReadLine());
        float pi = (float)Math.PI;
        float p = 2 * pi * r;
        float s = pi * r * r;
        Console.WriteLine("perimeter = {0:0.00}", p);
        Console.WriteLine("area = {0:0.00}", s);
    }
}