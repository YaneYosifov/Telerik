/*
 * We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several neighbour 
 * elements located on the same line, column or diagonal.
 * Write a program that finds the longest 
 * sequence of equal strings in the matrix.
 */

using System;
class SequenceNMatrix
{
    static void Main()
    {
        string[,] matrix = {{"ff", "hi", "fo", "hi"},
                           {"ou", "fo", "hh", "hh"},
                           {"fo", "ou", "ff", "hi"}};

        string bestSequenceStr = "sequence not found";
        string currSequenceStr = string.Empty;
        int bestSequenceInt = 1;
        int currSequenceInt = 1;
        int row = 0, col = 0;

        // horizontal
        for (row = 0; row < matrix.GetLength(0); row++)
        {
            for (col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currSequenceStr = matrix[row, col];
                    currSequenceInt++;
                }
                if (currSequenceInt > bestSequenceInt)
                {
                    bestSequenceStr = matrix[row, col];
                    bestSequenceInt = currSequenceInt;
                }
            }
            currSequenceInt = 1;
        }

        // vertical
        for (col = 0; col <= matrix.GetLength(0); col++)
        {
            for (row = 0; row < matrix.GetLength(1) - 2; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currSequenceStr = matrix[row, col];
                    currSequenceInt++;
                }
                if (currSequenceInt > bestSequenceInt)
                {
                    bestSequenceStr = matrix[row, col];
                    bestSequenceInt = currSequenceInt;
                }
            }
            currSequenceInt = 1;
        }

        // diagonal top-left bottom-right
        for (row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currCol = col;
                int currRow = row;

                while (currRow < matrix.GetLength(0) - 1 && currCol < matrix.GetLength(1) - 1 &&
                    matrix[currRow, currCol] == matrix[currRow + 1, currCol + 1])
                {
                    currSequenceStr = matrix[currRow, currCol];
                    currSequenceInt++;

                    if (currSequenceInt > bestSequenceInt)
                    {
                        bestSequenceStr = matrix[currRow, currCol];
                        bestSequenceInt = currSequenceInt;
                    }
                    currRow++;
                    currCol++;
                }
                currSequenceInt = 1;
            }
        }

        // diagonal bottom-left top-right
        for (row = matrix.GetLength(0) - 1; row > 1; row--)
        {
            for (col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currCol = col;
                int currRow = row;

                while (currRow > 0 && currCol < matrix.GetLength(1) - 1 &&
                    matrix[currRow, currCol] == matrix[currRow - 1, currCol + 1])
                {
                    currSequenceStr = matrix[currRow, currCol];
                    currSequenceInt++;

                    if (currSequenceInt > bestSequenceInt)
                    {
                        bestSequenceStr = matrix[currRow, currCol];
                        bestSequenceInt = currSequenceInt;
                    }
                    currRow--;
                    currCol++;
                }
                currSequenceInt = 1;
            }
        }

        for (int i = 0; i < bestSequenceInt - 1; i++)
        {
            Console.Write("{0}, ", bestSequenceStr);
        }
        Console.WriteLine(bestSequenceStr);
    }
}