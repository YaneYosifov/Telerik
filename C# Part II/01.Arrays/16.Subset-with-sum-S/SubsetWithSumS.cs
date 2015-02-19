/*
 * We are given an array of integers and a number S.
 * Write a program to find if there exists a subset 
 * of the elements of the array that has a sum S.
 */

using System;
using System.Collections.Generic;
class SubsetWithSumS
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers, separated by a comma:");
        string arrStr = Console.ReadLine();
        int[] array = Array.ConvertAll(arrStr.Split(','), int.Parse);
        Console.Write("S = ");
        int s = int.Parse(Console.ReadLine());

        combine(array, new List<int>(), 0, s);
    }
    static void combine(int[] a, List<int> outstr, int index, int s)
    {
        for (int i = index; i < a.Length; i++)
        {
            int count = 0;
            foreach (var item in outstr)
                count += item;

            if ((a[i] + count) == s)
            {
                foreach (var item in outstr)
                    Console.Write("{0} + ", item);

                Console.Write("{0} = {1}", a[i], s);
                Console.WriteLine();
            }

            outstr.Add(a[i]);
            combine(a, outstr, i + 1, s);
            outstr.Remove(a[i]);
        }
    }
}