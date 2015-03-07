/*
 * Write a method that checks if the element at given position in given array 
 * of integers is larger than its two neighbours (when such exist).
 */

namespace LargerThanNeighbours
{
    using System;
    class LargerThanNeighbours
    {
        static void Main()
        {
            Console.WriteLine("Enter the numbers of array, separated by a space:");
            string[] input = Console.ReadLine().Split();
            int[] array = Array.ConvertAll(input, int.Parse);

            Console.Write("Enter an element index: ");
            int index = int.Parse(Console.ReadLine());

            NumbersCollection numbers = new NumbersCollection(array, index);
        }
    }
}