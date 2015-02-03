using System;
using System.Numerics;
class TrailingZeroesInN
{
    static void Main()
    {
        // * Write a program that calculates with how many zeroes 
        //   the factorial of a given number n has at its end.
        // * Your program should work well for very big numbers, e.g. n=100000.

        Console.Write("n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger counter = 0;

        for (BigInteger i = n - 1; i > 0; i--)
        {
            n *= i;
        }

        while (true)
        {
            if (n % 10 == 0)
            {
                counter++;
                n /= 10;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(counter);
    }
}