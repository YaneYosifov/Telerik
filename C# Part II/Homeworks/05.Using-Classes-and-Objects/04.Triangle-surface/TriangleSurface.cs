/*
 * Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it;
 * Three sides;
 * Two sides and an angle between them;
 * Use System.Math.
 */

using System;
class TriangleSurface
{
    static void CalcAreaBySideAndAltitude()
    {
        Console.Write("Enter side length: ");
        double triangleSide = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude: ");
        double triangleAltitude = double.Parse(Console.ReadLine());

        Console.WriteLine("Area = {0}\n", 0.5 * triangleSide * triangleAltitude); 
    }

    static void CalcAreaByThreeSides()
    {
        Console.Write("side a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("side b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("side c = ");
        double c = double.Parse(Console.ReadLine());

        double s = (a + b + c) / 2;
        Console.WriteLine("Area = {0}\n", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
    }

    static void CalcAreaByTwoSidesAndAngle()
    {
        Console.Write("side a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("side b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("angle = ");
        double angleC = double.Parse(Console.ReadLine());

        double c = Math.Sqrt(a * a + b * b - a * b * Math.Cos(angleC));
        double s = (a + b + c) / 2;
        Console.WriteLine("Area = {0}\n", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
    }

    static void Main()
    {
        Console.WriteLine("Calculate area of triangle by:");
        Console.WriteLine("1 --> Side and an altitude to it");
        Console.WriteLine("2 --> Three sides");
        Console.WriteLine("3 --> Two sides and an angle between them");
        Console.WriteLine("4 --> Exit");
        Console.Write("Enter your choise 1/2/3/4: ");
        int choise = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choise)
        {
            case 1: CalcAreaBySideAndAltitude(); Main(); break;
            case 2: CalcAreaByThreeSides(); Main(); break;
            case 3: CalcAreaByTwoSidesAndAngle(); Main(); break;
            case 4: break;
        }
    }
}