/*
 * Write a program that finds the sequence of maximal sum in given array.
 */

using System;
class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers, separated by a comma:");
        string arrStr = Console.ReadLine();
        int[] array = Array.ConvertAll(arrStr.Split(','), int.Parse);

        int currentSum = 0;
        int maxSum = array[0];
        int startIndex = 0;
        int endIndex = 0;
        int tmpStartIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = array[i];
                tmpStartIndex = i;
            }
            else
            {
                currentSum += array[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = tmpStartIndex;
                endIndex = i;
            }
        }

        Console.WriteLine("\nMaximal sum is {0}", maxSum);
        Console.WriteLine("The sequence of numbers is: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write("{0}", array[i]);
            if (i < endIndex)
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}