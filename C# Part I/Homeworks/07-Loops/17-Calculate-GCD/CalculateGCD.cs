using System;
class CalculateGCD
{
    static void Main()
    {
        // * Write a program that calculates the greatest common 
        //   divisor (GCD) of given two integers a and b.
        // * Use the Euclidean algorithm (find it in Internet).

        Console.Write("a = ");
        int a = Math.Abs(int.Parse(Console.ReadLine()));
        Console.Write("b = ");
        int b = Math.Abs(int.Parse(Console.ReadLine()));

         while (a != 0 && b != 0)
         {
             if (a > b)
                a %= b;
             else
                b %= a;
         }

         if (a == 0)
             Console.WriteLine(b);
         else
             Console.WriteLine(a);
    }
}