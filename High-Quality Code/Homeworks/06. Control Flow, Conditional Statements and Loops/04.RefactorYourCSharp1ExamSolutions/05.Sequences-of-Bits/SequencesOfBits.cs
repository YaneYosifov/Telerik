namespace Exam
{
    using System;
    using System.Text;

    public class SequencesOfBits
    {
        public static void Main()
        {
            int listOfNumbers = int.Parse(Console.ReadLine());
            StringBuilder bits = new StringBuilder();

            for (int i = 0; i < listOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bits.Append(Convert.ToString(number, 2).PadLeft(30, '0'));
            }

            int onesLength = GetMaxSequenceLength(bits.ToString(), '1');
            int zerosLength = GetMaxSequenceLength(bits.ToString(), '0');

            Console.WriteLine(onesLength);
            Console.WriteLine(zerosLength);
        }

        private static int GetMaxSequenceLength(string text, char ch)
        {
            int length = 0;
            int maxLength = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == ch && text[i] == text[i + 1])
                {
                    length++;
                    maxLength = Math.Max(maxLength, length + 1);
                }
                else if (text[i] == ch ^ text[i + 1] == ch)
                {
                    length = 0;
                    maxLength = Math.Max(maxLength, 1);
                }
                else
                {
                    length = 0;
                }
            }

            return maxLength;
        }
    }
}