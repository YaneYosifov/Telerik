using System;
class PointInACircle
{
    static void Main()
    {
        // * Write an expression that checks if given point (x, y) 
        //   is inside a circle K({0, 0}, 2).

        float radius = 2f;
        Console.Write("Enter X coordinate: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Enter Y coordiante: ");
        float y = float.Parse(Console.ReadLine());

        bool point = x * x + y * y <= radius * radius;
        Console.WriteLine(point);
    }
}