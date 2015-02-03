using System;
class SumOf5Numbers
{
    static void Main()
    {
        // * Write a program that enters 5 numbers (given in a single line, 
        //   separated by a space), calculates and prints their sum.

        Console.WriteLine("Enter 5 numbers, separated by a space:");
        string n = Console.ReadLine();
        double total = 0;
        foreach (string tokenNum in n.Split(' '))
        {
            double num = double.Parse(tokenNum);
            total += num;
        }
        Console.WriteLine(total);
    }
}