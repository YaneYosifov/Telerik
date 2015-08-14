namespace RotatingWalkInMatrix
{
    using System;

    public class UserInput
    {
        public static int GetNumber(string input)
        {
            int length = 0;
            while (!int.TryParse(input, out length) || length < 1 || length > 100)
            {
                // throw new Exception();
                Console.WriteLine("You haven't entered a correct number!");
                Console.Write("Please enter a number in range [1...100]: ");
                input = Console.ReadLine();
            }

            Console.WriteLine();

            return length;
        }
    }
}
