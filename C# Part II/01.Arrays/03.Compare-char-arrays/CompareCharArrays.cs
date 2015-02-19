/*
 * Write a program that compares two char 
 * arrays lexicographically (letter by letter).
 */

using System;
class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter length of the first char array: ");
        int firstLength = int.Parse(Console.ReadLine());
        char[] firstArr = new char[firstLength];
        Console.WriteLine("Enter {0} characters: ", firstLength);
        for (int i = 0; i < firstLength; i++)
        {
            Console.Write("firstArr[{0}] = ", i);
            firstArr[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("\nEnter length of the second char array: ");
        int secondLength = int.Parse(Console.ReadLine());
        char[] secondArr = new char[secondLength];
        Console.WriteLine("Enter {0} characters: ", secondLength);
        for (int i = 0; i < firstLength; i++)
        {
            Console.Write("secondArr[{0}] = ", i);
            secondArr[i] = char.Parse(Console.ReadLine());
        }

        bool isEqual = true;

        if (firstArr == secondArr)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    isEqual = false;
                    break;
                }
            }
        }

        if (isEqual)
        {
            Console.WriteLine("\nThe two arrays are EQUAL");
        }
        else
        {
            Console.WriteLine("\nThe two arrays are NOT equal");
        }
    }
}