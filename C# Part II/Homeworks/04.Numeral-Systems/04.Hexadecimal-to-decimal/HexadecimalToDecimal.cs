/*
 * Write a program to convert hexadecimal numbers 
 * to their decimal representation.
 */

using System;
class HexadecimalToDecimal
{
    static long HexToDec(string hexNumber)
    {
        long decNumber = 0;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            int digit = 0;
            if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
            {
                digit = hexNumber[i] - '0';
            }
            else if (hexNumber[i] >= 'A' && hexNumber[i] <= 'F')
            {
                digit = hexNumber[i] - 'A' + 10;
            }

            decNumber += digit * (long)Math.Pow(16, hexNumber.Length - i - 1);
        }
        return decNumber;
    }
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexNum = Console.ReadLine();
        Console.WriteLine("Converted to decimal: {0}", HexToDec(hexNum));
    }
}