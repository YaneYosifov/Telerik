using System;
class MultiverseCommunication
{
    static long ThirteenthToDecimal(string thirteenth)
    {
        long decNumber = 0;
        for (int i = 0; i < thirteenth.Length; i++)
        {
            long digit = 0;
            if (thirteenth[i] >= '0' && thirteenth[i] <= '9')
            {
                digit = thirteenth[i] - '0';
            }
            else
            {
                digit = thirteenth[i] - 'A' + 10;
            }

            decNumber += digit * (long)Math.Pow(13, thirteenth.Length - i - 1);
        }
        return decNumber;
    }
    static void Main()
    {
        string input = Console.ReadLine();
        string[] alphabet = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
        string result13th = string.Empty;

        for (int i = 0; i < input.Length / 3; i++)
        {
            string threeLetters = input.Substring(i * 3, 3);
            for (long j = 0; j < alphabet.Length; j++)
            {
                long compare = string.Compare(alphabet[j], threeLetters);
                if (compare == 0)
                {
                    if (j % 13 >= 0 && j % 13 <= 9)
                    {
                        result13th += (j % 13);
                    }
                    else if (j % 13 >= 10 && j % 13 <= 12)
                    {
                        result13th += (char)(j % 13 - 10 + 'A');
                    }
                    break;
                }
            }
        }

        long decimalResult = ThirteenthToDecimal(result13th);
        Console.WriteLine(decimalResult);
    }
}