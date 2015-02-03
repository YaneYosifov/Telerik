﻿using System;
class MultiplicationSign
{
    static void Main()
    {
        // * Write a program that shows the sign (+, - or 0) of the product 
        //   of three real numbers, without calculating it.
        //   - Use a sequence of if operators.

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        else if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || 
                 (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0))
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}