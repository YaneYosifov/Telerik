/*
 * Write a program to convert binary numbers to their decimal representation.
 */

using System;
class BinaryToDecimal
{
    static long ConvertBinaryToDecimal(string binNumber)
    {
        long decimalResult = 0;

        for (int i = 0; i < binNumber.Length; i++)
        {
            int digit = binNumber[i] - '0';
            decimalResult += digit * (long)Math.Pow(2, binNumber.Length - i - 1);
        }

        return decimalResult;
    }
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryNum = Console.ReadLine();
        Console.WriteLine("Converted to decimal: {0}", ConvertBinaryToDecimal(binaryNum));
    }
}