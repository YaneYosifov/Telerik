﻿/*
 * Write a program that sorts an array of strings using the Quick sort algorithm.
 */

using System;

class QuickSort
{
    static void Main()
    {
        Console.WriteLine("Enter a strings, separated by a comma or space:");
        string[] separators = { ", ", ",", " " };
        string rawUnsorted = Console.ReadLine();
        string[] unsorted = rawUnsorted.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        // Sort the array
        Quicksort(unsorted, 0, unsorted.Length - 1);

        // Print the sorted array
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }

        Console.ReadLine();
    }

    public static void Quicksort(IComparable[] elements, int left, int right)
    {
        int i = left, j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                IComparable tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}