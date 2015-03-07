using System;
class StrangeLandNumbers
{
    static long SeventhToDec(string SeventhNumber)
    {
        long decNumber = 0;
        for (int i = 0; i < SeventhNumber.Length; i++)
        {
            int digit = 0;
            digit = SeventhNumber[i] - '0';
            decNumber += digit * (long)Math.Pow(7, SeventhNumber.Length - i - 1);
        }
        return decNumber;
    }
    static void Main()
    {
        string input = Console.ReadLine()
            .Replace("f", "0")
            .Replace("bIN", "1")
            .Replace("oBJEC", "2")
            .Replace("mNTRAVL", "3")
            .Replace("lPVKNQ", "4")
            .Replace("pNWE", "5")
            .Replace("hT", "6");
        Console.WriteLine(SeventhToDec(input));
    }
}