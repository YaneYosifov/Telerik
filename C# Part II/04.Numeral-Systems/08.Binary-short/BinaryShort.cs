/*
 * Write a program that shows the binary representation 
 * of given 16-bit signed integer number (the C# type short).
 */

using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a short decimal number (-32768 to 32767): ");
        short decimalNum = short.Parse(Console.ReadLine());
        Console.WriteLine("Converted to binary: {0}", DecToBin(decimalNum));
    }

    static string DecToBin(long decimalNum)
    {
        string binaryNum = string.Empty;

        if (decimalNum > 0)
        {
            while (decimalNum != 0)
            {
                binaryNum = (decimalNum % 2) + binaryNum;
                decimalNum /= 2;
            }
        }
        else if (decimalNum < 0)
        {
            decimalNum += 1;
            while (decimalNum != 0)
            {
                binaryNum = (decimalNum % 2 + 1) + binaryNum;
                decimalNum /= 2;
            }
        }

        return binaryNum.PadLeft(16, '1');
    }
}