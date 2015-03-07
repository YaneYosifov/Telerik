using System;
class MultiverseCommunication
{
    static string DecTo26(long decimalNum)
    {
        string num26 = string.Empty;

        while (decimalNum > 0)
        {
            num26 = (char)(decimalNum % 26 + 'a') + num26;
            decimalNum /= 26;
        }

        return num26;
    }
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string[] output = new string[input.Length];
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        int currLetter;
        long result21 = 0;

        for (int i = 0; i < input.Length; i++)
        {
            string word = input[i];
            result21 = 0;
            for (int j = 0; j < word.Length; j++)
            {
                currLetter = alphabet.IndexOf(word[j]);
                long power = 1;
                for (int k = 0; k < word.Length - j - 1; k++)
                {
                    power *= 21;
                }
                result21 += currLetter * power;
            }
            output[i] = DecTo26(result21);
        }

        Console.WriteLine(string.Join(" ", output));
    }
}