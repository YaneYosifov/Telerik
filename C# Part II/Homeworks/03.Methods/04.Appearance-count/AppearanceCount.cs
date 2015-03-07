/*
 * Write a method that counts how many times 
 * given number appears in given array.
 * Write a test program to check if the method is workings correctly.
 */

using System;
class AppearanceCount
{
    static int HowManyTimes(int[] sequence, int dupCheck)
    {
        int counter = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == dupCheck)
            {
                counter++;
            }
        }

        return counter;
    }
    static void Main()
    {
        Console.WriteLine("Enter the numbers of array, separated by a space:");
        string[] tmp = Console.ReadLine().Split();
        int[] array = Array.ConvertAll(tmp, int.Parse);

        Console.Write("Enter a number to check for duplications: ");
        int duplication = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} appears {1} times", duplication, HowManyTimes(array, duplication));
    }
}