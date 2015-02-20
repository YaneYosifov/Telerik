/*
 * You are given a sequence of positive integer values 
 * written into a string, separated by spaces.
 * Write a function that reads these values 
 * from given string and calculates their sum.
 */

using System;
using System.Linq;
class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of positive integer values, separated by spaces: ");
        int[] sequence = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int sum = sequence.Sum();
        Console.WriteLine(sum);
    }
}