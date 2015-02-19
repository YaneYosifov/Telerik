/*
 * Write a program that finds in given array of integers 
 * a sequence of given sum S (if present).
 */

using System;
class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers, separated by a comma:");
        string arrStr = Console.ReadLine();
        int[] array = Array.ConvertAll(arrStr.Split(','), int.Parse);

        Console.Write("S = ");
        int s = int.Parse(Console.ReadLine());
        int sum = 0;

        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (sum < s)
                {
                    sum += array[j];
                }
                if (sum == s)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write("{0}", array[k]);
                        if (k < j)
                            Console.Write(" + ");
                        else
                            Console.WriteLine(" = {0}", sum);
                    }
                    sum = 0;
                    break;
                }
                else if (sum > s)
                {
                    sum = 0;
                    break;
                }
            }
        }
    }
}