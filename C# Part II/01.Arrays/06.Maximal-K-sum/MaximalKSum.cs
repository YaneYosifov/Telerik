/*
 * Write a program that reads two integer numbers N and K 
 * and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
 */

using System;
class MaximalKSum
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0} = ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        int sum = 0;
        Console.WriteLine();
        for (int i = 0; i < k; i++)
        {
            sum += numbers[numbers.Length - 1 - i];
            Console.Write("{0}", numbers[numbers.Length - 1 - i]);
            if (i < k - 1)
            {
                Console.Write(" + ");
            }
            else
            {
                Console.WriteLine(" = {0}", sum);
            }
        }
    }
}