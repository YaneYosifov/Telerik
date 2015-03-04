/*
 * Write a program that reads a text file 
 * containing a square matrix of numbers.
 * Find an area of size 2 x 2 in the matrix, with a maximal sum of elements.
 * The first line in the input file contains the size of matrix N.
 * Each of the next N lines contain N numbers separated by space.
 * The output should be a single number in a separate text file.
 */

using System;
using System.IO;
using System.Linq;
class MaximalAreaSum
{
    static void Main()
    {
        StreamReader matrixTxt = new StreamReader("Matrix.txt");
        int size = matrixTxt.Read() - '0';
        matrixTxt.ReadLine();

        string[] lineStr;
        int[] line;

        int[,] matrix = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            lineStr = matrixTxt.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            line = lineStr.Select(n => Convert.ToInt32(n)).ToArray();
            for (int j = 0; j < size; j++)
            {
                matrix[i,j] = line[j];
            }
        }

        int sum = 0;
        int bestSum = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }

        StreamWriter output = new StreamWriter("Output.txt");
        output.Write(bestSum);

        matrixTxt.Close();
        output.Close();
    }
}