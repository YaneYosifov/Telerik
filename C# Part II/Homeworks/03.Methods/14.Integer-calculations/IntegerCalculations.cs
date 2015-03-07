/*
 * Write methods to calculate minimum, maximum, average, sum 
 * and product of given set of integer numbers.
 * Use variable number of arguments.
 */

using System;
class IntegerCalculations
{
    static int Minimum(params int[] collection)
    {
        int min = collection[0];
        for (int i = 1; i < collection.Length; i++)
        {
            if (min > collection[i])
            {
                min = collection[i];
            }
        }
        return min;
    }

    static int Maximum(params int[] collection)
    {
        int max = collection[0];
        for (int i = 1; i < collection.Length; i++)
        {
            if (max < collection[i])
            {
                max = collection[i];
            }
        }
        return max;
    }

    static int Average(params int[] collection)
    {
        int sum = Sum(collection);
        int avg = sum / collection.Length;
        return avg;
    }

    static int Sum(params int[] collection)
    {
        int sum = 0;
        foreach (int num in collection)
        {
            sum += num;
        }
        return sum;
    }

    static int Product(params int[] collection)
    {
        int product = 1;
        foreach (int num in collection)
        {
            product *= num;
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("Minimal number is {0}", Minimum(11, 34, 56, 89, 5, 31, 64, 23, 2, 56, 27));
        Console.WriteLine("Maximal number is {0}", Maximum(11, 34, 56, 89, 5, 31, 64, 23, 2, 56, 27));
        Console.WriteLine("Average value of all numbers is {0}", Average(11, 34, 56, 89, 5, 31, 64, 23, 2, 56, 27));
        Console.WriteLine("Sum of all numbers is {0}", Sum(11, 34, 56, 89, 5, 31, 64, 23, 2, 56, 27));
        Console.WriteLine("Product of all numbers is {0}", Product(11, 34, 56, 89, 5, 31, 64, 23, 2, 56, 27));
    }
}