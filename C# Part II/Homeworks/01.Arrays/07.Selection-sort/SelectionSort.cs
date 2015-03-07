/*
 * Sorting an array means to arrange its elements in 
 * increasing order. Write a program to sort an array.
 * Use the Selection sort algorithm: Find the smallest element, 
 * move it at the first position, find the smallest 
 * from the rest, move it at the second position, etc.
 */

using System;
class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers, separated by a comma:");
        string arrStr = Console.ReadLine();
        int[] numbers = Array.ConvertAll(arrStr.Split(','), int.Parse);

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i; j < numbers.Length; j++)
			{
                if (numbers[j] < numbers[i])
                {
                    numbers[i] ^= numbers[j];
                    numbers[j] ^= numbers[i];
                    numbers[i] ^= numbers[j];
                }
			}
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}