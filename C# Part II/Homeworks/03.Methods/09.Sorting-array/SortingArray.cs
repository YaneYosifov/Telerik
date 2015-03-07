/*
 * Write a method that return the maximal element 
 * in a portion of array of integers starting at given index.
 * Using it write another method that sorts 
 * an array in ascending / descending order.
 */

using System;
using System.Linq;
class SortingArray
{
    static int[] FindMax(int[] numbers, int start, int end)
    {
        Array.Sort(numbers, start, end - start + 1);
        return numbers;
    }

    static int[] SortAscending(int[] numbers)
    {
        FindMax(numbers, 0, numbers.Length - 1);
        return numbers;
    }
    static int[] SortDescending(int[] numbers)
    {
        FindMax(numbers, 0, numbers.Length - 1);
        Array.Reverse(numbers);
        return numbers;
    }
    static void Main()
    {
        Console.WriteLine("Enter the numbers of array, separated by a space:");
        string[] input = Console.ReadLine().Split();
        int[] nums = Array.ConvertAll(input, int.Parse);

        Console.Write("Enter start index: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());

        FindMax(nums, start, end);
        Console.WriteLine("Maximal element in the range [{0}] - [{1}] is {2}", start, end, nums[end]);
        Console.WriteLine("Sorted ascending: {0}", string.Join(" ", SortAscending(nums)));
        Console.WriteLine("Sorted descending: {0}", string.Join(" ", SortDescending(nums)));
    }
}