using System;
class FourDigitNumber
{
    static void Main()
    {
        // Write a program that takes as input a four-digit number 
        // in format abcd (e.g. 2011) and performs the following:
        // * Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        // * Prints on the console the number in reversed order: dcba (in our example 1102).
        // * Puts the last digit in the first position: dabc (in our example 1201).
        // * Exchanges the second and the third digits: acbd (in our example 2101).
        // * The number has always exactly 4 digits and cannot start with 0.

        int n = int.Parse(Console.ReadLine());
        int a, b, c, d;
        a = n / 1000;
        b = n / 100 % 10;
        c = n / 10 % 10;
        d = n % 10;

        Console.WriteLine(a + b + c + d);
        Console.WriteLine("{3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("{3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("{0}{2}{1}{3}", a, b, c, d);
    }
}
