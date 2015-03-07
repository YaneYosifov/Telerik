/*
 * Write a program that fills and prints a matrix of n (n, n) as shown below:
 * Example for n=4
 */

using System;
class FillTheMatrixA
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        // Variant A
        Console.WriteLine();
        for (int row = 0; row < n; row++)
        {
            int num = row + 1;
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = num;
                Console.Write("{0,-2} ", matrix[row, col]);
                num += n;
            }
            Console.WriteLine();
        }

        // Variant B
        Console.WriteLine();
        Array.Clear(matrix, 0, matrix.Length);

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                if (col == 1)
                {
                    matrix[row - 1, col - 1] = row;
                    Console.Write("{0,-2} ", matrix[row - 1, col - 1]);
                }
                else if (col % 2 != 0)
                {
                    matrix[row - 1, col - 1] = row + n * col - n;
                    Console.Write("{0,-2} ", matrix[row - 1, col - 1]);
                }
                else
                {
                    matrix[row - 1, col - 1] = n * col - row + 1;
                    Console.Write("{0,-2} ", matrix[row - 1, col - 1]);
                }
            }
            Console.WriteLine();
        }

        // Variant C
        Console.WriteLine();
        Array.Clear(matrix, 0, matrix.Length);

        int counter = 1;
        int rowBackCounter = 1;
        int colBackCounter = 0;
        int maxCount = n * n;

        for (int row = n - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(1); )
            {
                matrix[row, col] = counter;

                if (counter == maxCount)
                {
                    break;
                }
                else if (row == n - 1 && col != n - 1)
                {
                    row -= rowBackCounter;
                    col -= colBackCounter;
                    rowBackCounter++;
                    colBackCounter++;
                }
                else if (row == n - 1 || col == n - 1)
                {
                    colBackCounter--;
                    rowBackCounter--;
                    col -= colBackCounter;
                    row -= rowBackCounter;
                }
                else
                {
                    row++;
                    col++;
                }
                counter++;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-2} ", matrix[row, col]);
            }
            Console.WriteLine("\n");
        }
    }
}