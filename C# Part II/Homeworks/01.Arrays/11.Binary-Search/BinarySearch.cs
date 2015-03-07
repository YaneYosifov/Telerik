/*
 * Write a program that finds the index of given element in 
 * a sorted array of integers by using the Binary search algorithm.
 */

using System;
class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers, separated by a comma:");
        string arrStr = Console.ReadLine();
        int[] array = Array.ConvertAll(arrStr.Split(','), int.Parse);
        Console.Write("Enter the value you are searching for: ");
        int value = int.Parse(Console.ReadLine());

        Array.Sort(array);
        Console.WriteLine("\nNow array is sorted");
        Console.WriteLine(string.Join(", ", array));

        int index = Array.BinarySearch(array, value);
        Console.WriteLine("The value {0} has index {1} of the sorted array", value, index);
    }
}