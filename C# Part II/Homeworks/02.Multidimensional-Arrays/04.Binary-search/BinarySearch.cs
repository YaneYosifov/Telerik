/*
 * Write a program, that reads from the console an array of N integers 
 * and an integer K, sorts the array and using the method Array.BinSearch() 
 * finds the largest number in the array which is ≤ K.
 */

using System;
class BinarySearch
{
    static void Main()
    {
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", arr[i]);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        int index = Array.BinarySearch(arr, k);
        if (index < 0)
        {
            index = ~index - 1;
        }
        if (index >= 0)
        {
            result = arr[index];
        }
        Console.WriteLine(result);
    }
}