/*
 * Write a program to convert from any numeral system 
 * of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */

using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("s (s >= 2) = ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("d (d <= 16) = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter a number: ");
        string number = Console.ReadLine().ToUpper();
        Console.WriteLine("Converted from {0}-numeral system to {1}-numeral system: {2}",
            s, d, DecimalToBase(BaseToDecimal(s, number), d));
    }

    static long BaseToDecimal(int s, string number)
    {
        long decNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit = 0;
            if (number[i] >= '0' && number[i] <= '9')
            {
                digit = number[i] - '0';
            }
            else
            {
                digit = number[i] - 'A' + 10;
            }

            decNumber += digit * (long)Math.Pow(s, number.Length - i - 1);
        }
        return decNumber;
    }

    static string DecimalToBase(long number, int d)
    {
        string baseNum = string.Empty;
        while (number > 0)
        {
            if (number % d >= 0 && number % d <= 9)
            {
                baseNum = (number % d) + baseNum;
            }
            else
            {
                baseNum = (char)(number % d - 10 + 'A') + baseNum;
            }
            number /= d;
        }
        return baseNum;
    }
}