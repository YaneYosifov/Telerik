using System;
class EncodingSum
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        char[] text = Console.ReadLine().ToCharArray();
        long result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }
            else if (text[i] >= 48 && text[i] <= 57) // 0-9
            {
                int digit = int.Parse(text[i].ToString());
                result *= digit;
            }
            else if (text[i] >= 65 && text[i] <= 90) // A-Z
            {
                result += (text[i] - 65);
            }
            else if (text[i] >= 97 && text[i] <= 122) // a-z
            {
                result += (text[i] - 97);
            }
            else
            {
                result %= m;
            }
        }

        Console.WriteLine(result);
    }
}