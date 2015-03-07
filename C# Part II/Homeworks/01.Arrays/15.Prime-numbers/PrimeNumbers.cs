/*
 * Write a program that finds all prime numbers in the range [1...10 000 000]. 
 * Use the Sieve of Eratosthenes algorithm.
 */

using System;
using System.Linq;
class PrimeNumbers
{
    static void Main()
    {
        Console.BufferHeight = Int16.MaxValue - 1;

        bool[] array = Enumerable.Repeat(true, 10000000).ToArray();
        for (int i = 2; i < 10000000; i++)
        {
            if (array[i] == true)
            {
                for (int j = i + i; j < 10000000; j += i)
                {
                    array[j] = false;
                }
            }
        }

        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == true)
            {
                Console.Write("{0} ", i);
            }
        }

        Console.WriteLine();
    }
}