/*
 * Write a program to convert decimal numbers 
 * to their binary representation.
 */

using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decimalNum = long.Parse(Console.ReadLine());
        Console.WriteLine("Converted to binary: {0}", DecToBin(decimalNum));
    }

    static string DecToBin(long decimalNum)
    {
        string binaryNum = string.Empty;

        while (decimalNum > 0)
        {
            binaryNum = (decimalNum % 2) + binaryNum;
            decimalNum /= 2;
        }

        return binaryNum;
    }
}