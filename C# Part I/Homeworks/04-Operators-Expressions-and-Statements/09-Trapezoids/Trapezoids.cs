using System;
class Trapezoids
{
    static void Main()
    {
        // * Write an expression that calculates trapezoid's area by given sides a and b and height h.

        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("h = ");
        float h = float.Parse(Console.ReadLine());

        float area = ((a + b) / 2) * h;
        Console.WriteLine(area);
    }
}