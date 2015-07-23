namespace TelerikCSharpPart2Exam
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class BitShiftMatrix
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int moves = int.Parse(Console.ReadLine());
            int[] positions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            BigInteger[,] matrix = new BigInteger[rows, cols];
            BigInteger[,] filledMatrix = FillMatrix(matrix);
            BigInteger sum = SumPathCells(rows, cols, moves, positions, matrix);

            Console.WriteLine(sum);
        }

        private static BigInteger[,] FillMatrix(BigInteger[,] matrix)
        {
            BigInteger matrixFill = 1;
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixFill;
                    matrixFill += matrixFill;
                }

                matrixFill = matrix[row, 1];
            }

            return matrix;
        }

        private static BigInteger SumPathCells(int rows, int cols, int moves, int[] positions, BigInteger[,] matrix)
        {
            int coef = Math.Max(rows, cols);
            int row = matrix.GetLength(0) - 1;
            int col = 0;
            BigInteger sum = 0;
            BigInteger[,] newMatrix = new BigInteger[matrix.GetLength(0), matrix.GetLength(1)];
            Array.Copy(matrix, newMatrix, matrix.Length);
            for (int i = 0; i < moves; i++)
            {
                SumPathCols(positions[i], coef, row, ref col, ref sum, newMatrix);
                SumPathRows(positions[i], coef, ref row, col, ref sum, newMatrix);
            }

            return sum;
        }

        private static void SumPathCols(int position, int coef, int row, ref int col, ref BigInteger sum, BigInteger[,] matrix)
        {
            int nextCol = position % coef;
            int fromCol = Math.Min(col, nextCol);
            int toCol = Math.Max(col, nextCol);
            for (int j = fromCol; j <= toCol; j++)
            {
                sum += matrix[row, j];
                matrix[row, j] = 0;
            }

            col = nextCol;
        }

        private static void SumPathRows(int position, int coef, ref int row, int col, ref BigInteger sum, BigInteger[,] matrix)
        {
            int nextRow = position / coef;
            int fromRow = Math.Min(row, nextRow);
            int toRow = Math.Max(row, nextRow);
            for (int j = fromRow; j <= toRow; j++)
            {
                sum += matrix[j, col];
                matrix[j, col] = 0;
            }

            row = nextRow;
        }
    }
}
