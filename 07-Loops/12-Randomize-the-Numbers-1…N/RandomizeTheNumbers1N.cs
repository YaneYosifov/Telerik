using System;
using System.Linq;
class RandomizeTheNumbers1N
{
    static void Main()
    {
        // * Write a program that enters in integer n 
        //   and prints the numbers 1, 2, …, n in random order.

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        Random rnd = new Random();
        int[] randArr = numbers.OrderBy(x => rnd.Next()).ToArray();

        foreach (int item in randArr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}