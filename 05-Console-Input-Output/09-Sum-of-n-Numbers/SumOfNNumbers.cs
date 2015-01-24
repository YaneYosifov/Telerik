using System;
class SumOfNNumbers
{
    static void Main()
    {
        // * Write a program that enters a number n and after that 
        //   enters more n numbers and calculates and prints their sum.

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}