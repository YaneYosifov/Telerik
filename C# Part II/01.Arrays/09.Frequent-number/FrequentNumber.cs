/*
 * Write a program that finds the most frequent number in an array.
 */

using System;
class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers, separated by a comma:");
        string arrStr = Console.ReadLine();
        int[] array = Array.ConvertAll(arrStr.Split(','), int.Parse);

        int num = array[array.Length - 1];
        int counter = 1;
        int tmpCounter = 1;

        Array.Sort(array);
        for (int i = array.Length - 1; i > 0; i--)
        {
            if (tmpCounter > counter)
            {
                counter = tmpCounter;
                num = array[i];
            }
            if (array[i] == array[i - 1])
            {
                tmpCounter++;
            }
            else
            {
                tmpCounter = 1;
            }
        }

        Console.WriteLine("The most frequent number is {0} (repeated {1} times)", num, counter);
    }
}