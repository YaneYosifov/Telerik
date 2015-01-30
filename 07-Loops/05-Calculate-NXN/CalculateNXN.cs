using System;
class Calculate1NXN
{
    static void Main()
    {
        // * Write a program that, for a given two integer numbers n and x, 
        //   calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
        // * Use only one loop. Print the result 
        //   with 5 digits after the decimal point.

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        double s = 1;
        double fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            s += fact / Math.Pow(x, i);
        }
        Console.WriteLine("{0:F5}", s);
    }
}