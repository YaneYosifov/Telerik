using System;
using System.Numerics;
class CalculateNKNK
{
    static void Main()
    {
        // * In combinatorics, the number of ways to choose k different members 
        //   out of a group of n different elements (also known as 
        //   the number of combinations) is calculated by the following formula: 
        //   For example, there are 2598960 ways to withdraw 
        //   5 cards out of a standard deck of 52 cards.
        // * Your task is to write a program that calculates 
        //   n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
        //   Try to use only two loops.

        Console.WriteLine("condition: 1 < k < n < 100");
        Console.Write("n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("k = ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger nCount = n - 1;
        BigInteger kCount = k - 1;
        BigInteger nk = n - k;
        BigInteger nkCount = n - k - 1;

        for (BigInteger i = n - 1; i > 0; i--)
        {
            n *= nCount--;
            if (kCount > 0)
            {
                k *= kCount--;
            }
            if (nkCount > 0)
            {
                nk *= nkCount--;
            }
        }

        Console.WriteLine(n / (k * nk));
    }
}