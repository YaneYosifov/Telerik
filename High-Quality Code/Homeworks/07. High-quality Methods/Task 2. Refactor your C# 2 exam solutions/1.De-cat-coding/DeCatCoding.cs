namespace TelerikCSharpPart2Exam
{
    using System;

    public class DeCatCoding
    {
        public static void Main()
        {
            string[] inputWords = Console.ReadLine().Split();
            string[] result = new string[inputWords.Length];
            long in21thNotation = 0;

            for (int i = 0; i < inputWords.Length; i++)
            {
                in21thNotation = DecimalTo21thNotation(inputWords[i]);
                result[i] = BaseTo26thNotation(in21thNotation);
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static long DecimalTo21thNotation(string word)
        {
            int currentLetter = 0;
            const string ALPHABET = "abcdefghijklmnopqrstuvwxyz";
            long in21thNotation = 0;
            for (int j = 0; j < word.Length; j++)
            {
                currentLetter = ALPHABET.IndexOf(word[j]);
                in21thNotation += currentLetter * (long)Math.Pow(21, word.Length - j - 1);
            }

            return in21thNotation;
        }

        private static string BaseTo26thNotation(long toConvert)
        {
            string in26thNotation = string.Empty;
            while (toConvert > 0)
            {
                in26thNotation = (char)((toConvert % 26) + 'a') + in26thNotation;
                toConvert /= 26;
            }

            return in26thNotation;
        }
    }
}