using System;
using System.Numerics;
class CalculateNK
{
    static void Main()
    {
        // * Write a program that calculates n! / k! 
        //   for given n and k (1 < k < n < 100).
        // * Use only one loop.

        Console.WriteLine("condition: 1 < k < n < 100");
        Console.Write("n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("k = ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger counter = k - 1;

        for (BigInteger i = n - 1; i > 0; i--)
        {
            n *= i;
            if (counter > 0)
            {
                k *= counter--;
            }
        }

        Console.WriteLine(n/k);
    }
}