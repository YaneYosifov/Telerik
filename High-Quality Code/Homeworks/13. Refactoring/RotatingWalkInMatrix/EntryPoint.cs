namespace RotatingWalkInMatrix
{
    using System;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number in range [1...100]: ");
            int length = UserInput.GetNumber(Console.ReadLine());
            Matrix matrix = new Matrix(length);
            string drawnMatrix = matrix.Draw();
            Console.WriteLine(drawnMatrix);
        }
    }
}
