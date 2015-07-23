namespace TelerikCSharpPart2Exam
{
    using System;
    using System.Linq;

    public class IncreasingAbsoluteDifferences
    {
        public static void Main()
        {
            int numberOfSequences = int.Parse(Console.ReadLine());

            string[] sequences = new string[numberOfSequences];
            for (int i = 0; i < numberOfSequences; i++)
            {
                sequences[i] = Console.ReadLine();
            }

            for (int i = 0; i < sequences.Length; i++)
            {
                int[] absDifference = CreateAbsDifference(sequences[i]);
                Console.WriteLine(IsIncreasingSequence(absDifference));
            }
        }

        private static int[] CreateAbsDifference(string input)
        {
            int[] current = input.Split().Select(int.Parse).ToArray();
            int[] result = new int[current.Length - 1];
            for (int num = 0; num < current.Length - 1; num++)
            {
                int bigger = Math.Max(current[num], current[num + 1]);
                int smaller = Math.Min(current[num], current[num + 1]);
                result[num] = Math.Abs(bigger - smaller);
            }

            return result;
        }

        private static bool IsIncreasingSequence(int[] absDifference)
        {
            bool isIncreasingSequence = true;
            for (int i = 0; i < absDifference.Length - 1; i++)
            {
                if (!(absDifference[i + 1] - absDifference[i] == 0 || absDifference[i + 1] - absDifference[i] == 1))
                {
                    isIncreasingSequence = false;
                    break;
                }
            }

            return isIncreasingSequence;
        }
    }
}