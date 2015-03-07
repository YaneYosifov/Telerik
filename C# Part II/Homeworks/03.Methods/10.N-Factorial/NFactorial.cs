/*
 * Write a program to calculate n! for each n in the range [1..100].
 */

using System;
using System.Numerics;
class NFactorial
{
    static BigInteger Factorial(BigInteger factorial)
    {
        for (int i = (int)factorial - 1; i > 0; i--)
        {
            factorial *= i;
        }

        return factorial;
    }

    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0}! = {1}", i, Factorial(i));
            Console.WriteLine();
        }
    }
}