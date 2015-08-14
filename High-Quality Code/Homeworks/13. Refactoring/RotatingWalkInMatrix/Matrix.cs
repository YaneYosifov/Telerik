namespace RotatingWalkInMatrix
{
    using System;
    using System.Text;

    public class Matrix
    {
        private const int Seven = 7;
        private const int Eight = 8;
        private readonly int[] dirXMask = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private readonly int[] dirYMask = { 1, 0, -1, -1, -1, 0, 1, 1 };
        private int length;

        public Matrix(int length)
        {
            this.Length = length;
            this.Body = new int[length, length];
            this.Generate();
        }

        public int[,] Body { get; set; }

        internal int Length
        {
            get { return this.length; }
            private set { this.length = value; }
        }

        public string Draw()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < this.Body.GetLength(0); row++)
            {
                for (int col = 0; col < this.Body.GetLength(1); col++)
                {
                    sb.Append(string.Format("{0,4}", this.Body[row, col]));
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        internal int[,] Generate()
        {
            int row = 0;
            int col = 0;
            int count = 1;
            this.FillHalf(this.Body, this.length, ref row, ref col, ref count);

            // If lenght <= 4 whole matrix is filled,
            // otherwise only first part is filled
            // so second part needs to be filled too
            if (this.length > 4)
            {
                row = 2;
                col = 1;
                count++;
                this.FillHalf(this.Body, this.length, ref row, ref col, ref count);
            }

            return this.Body;
        }

        private void FillHalf(int[,] matrix, int n, ref int row, ref int col, ref int count)
        {
            int posX = 1;
            int posY = 1;
            while (true)
            {
                matrix[row, col] = count;
                if (!this.IsFilled(matrix, row, col))
                {
                    break;
                }

                if (row + posX >= n || row + posX < 0 || col + posY >= n || col + posY < 0 || matrix[row + posX, col + posY] != 0)
                {
                    while (row + posX >= n || row + posX < 0 || col + posY >= n || col + posY < 0 || matrix[row + posX, col + posY] != 0)
                    {
                        this.ChangePosition(ref posX, ref posY);
                    }
                }

                row += posX;
                col += posY;
                count++;
            }
        }

        private void ChangePosition(ref int x, ref int y)
        {
            int[] dirX = new int[this.dirXMask.Length];
            int[] dirY = new int[this.dirYMask.Length];
            Array.Copy(this.dirXMask, dirX, dirX.Length);
            Array.Copy(this.dirYMask, dirY, dirY.Length);

            int count = 0;
            for (int i = 0; i < Eight; i++)
            {
                if (dirX[i] == x && dirY[i] == y)
                {
                    count = i;
                    break;
                }
            }

            if (count == Seven)
            {
                x = dirX[0];
                y = dirY[0];
                return;
            }

            x = dirX[count + 1];
            y = dirY[count + 1];
        }

        private bool IsFilled(int[,] arr, int x, int y)
        {
            int[] dirX = new int[this.dirXMask.Length];
            int[] dirY = new int[this.dirYMask.Length];
            Array.Copy(this.dirXMask, dirX, dirX.Length);
            Array.Copy(this.dirYMask, dirY, dirY.Length);

            for (int i = 0; i < Eight; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < Eight; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
