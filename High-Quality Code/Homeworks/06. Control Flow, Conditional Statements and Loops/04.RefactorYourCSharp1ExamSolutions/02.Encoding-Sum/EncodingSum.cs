namespace Exam
{
    using System;

    public class EncodingSum
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            char[] text = Console.ReadLine().ToCharArray();
            long result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    break;
                }
                else if (text[i] >= '0' && text[i] <= '9')
                {
                    int digit = int.Parse(text[i].ToString());
                    result *= digit;
                }
                else if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    result += text[i] - 'A';
                }
                else if (text[i] >= 'a' && text[i] <= 'z')
                {
                    result += text[i] - 'a';
                }
                else
                {
                    result %= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}