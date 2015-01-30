using System;
class MatrixOfNumbers
{
    static void Main()
    {
        // * Write a program that reads from the console a positive 
        //   integer number n (1 ≤ n ≤ 20) and prints a matrix like 
        //   in the examples below. Use two nested loops.

        Console.Write("Enter a number between 1 and 20: ");
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int num = row; num < row + n; num++)
            {
                Console.Write("{0,2} ", num);
            }
            Console.WriteLine();
        }
    }
}
