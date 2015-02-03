using System;
using System.Linq;
class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        // * Write a program that reads from the console 
        //   a sequence of n integer numbers and returns the minimal, 
        //   the maximal number, the sum and the average of all numbers 
        //   (displayed with 2 digits after the decimal point).
        // * The input starts by the number n (alone in a line) 
        //   followed by n lines, each holding an integer number.
        // * The output is like in the examples below.

        Console.Write("Lines of numbers: ");
        int index = int.Parse(Console.ReadLine());
        int[] lines = new int[index];

        for (int i = 0; i < index; i++)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            lines[i] = n;
        }

        Console.WriteLine("min = " + lines.Min());
        Console.WriteLine("max = " + lines.Max());
        Console.WriteLine("sum = " + lines.Sum());
        Console.WriteLine("avg = {0:0.00}", lines.Average());
    }
}