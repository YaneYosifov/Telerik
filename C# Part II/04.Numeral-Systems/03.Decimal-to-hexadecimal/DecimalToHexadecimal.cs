/*
 * Write a program to convert decimal numbers 
 * to their hexadecimal representation.
 */

using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decimalNum = long.Parse(Console.ReadLine());
        Console.WriteLine("Converted to hexadecimal: {0}", DecToHex(decimalNum));
    }

    static string DecToHex(long decimalNum)
    {
        string hexNum = string.Empty;

        while (decimalNum > 0)
        {
            if (decimalNum % 16 >= 0 && decimalNum % 16 <= 9)
            {
                hexNum = (decimalNum % 16) + hexNum;
            }
            else if (decimalNum % 16 >= 10 && decimalNum % 16 <= 15)
            {
                hexNum = (char)(decimalNum % 16 - 10 + 'A') + hexNum;
            }
            decimalNum /= 16;
        }

        return hexNum;
    }
}