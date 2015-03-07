/* 
 * Write a program that reads two integer arrays from 
 * the console and compares them element by element.
 */

using System;
class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter length of the first array: ");
        int firstLength = int.Parse(Console.ReadLine());
        int[] firstArr = new int[firstLength];
        Console.WriteLine("Enter {0} integer numbers for the first array:", firstLength);
        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.Write("firstArr[{0}] = ", i);
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nEnter length of the second array: ");
        int secondLength = int.Parse(Console.ReadLine());
        int[] secondArr = new int[secondLength];
        Console.WriteLine("Enter {0} integer numbers for the second array:", secondLength);
        for (int i = 0; i < secondArr.Length; i++)
        {
            Console.Write("secondArr[{0}] = ", i);
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        if (firstLength == secondLength)
        {
            for (int i = 0; i < firstLength; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine("The two arrays are NOT equal");
                    return;
                }
            }
            Console.WriteLine("The two arrays are EQUAL");
        }
        else
        {
            Console.WriteLine("The two arrays are NOT equal");
        }
    }
}