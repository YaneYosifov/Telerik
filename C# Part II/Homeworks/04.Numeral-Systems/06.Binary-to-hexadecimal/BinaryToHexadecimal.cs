/*
 * Write a program to convert binary numbers to hexadecimal numbers (directly).
 */

using System;
class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        if (binaryNumber.Length % 4 != 0)
        {
            binaryNumber = binaryNumber
                .PadLeft(binaryNumber.Length + (4 - binaryNumber.Length % 4), '0');
        }
        Console.WriteLine("Converted to hexadecimal: {0}", string.Join("", BinaryToHex(binaryNumber)));
    }

    static string[] BinaryToHex(string binaryNumber)
    {
        string[] hexNumber = new string[binaryNumber.Length / 4];
        for (int i = 0; i < hexNumber.Length; i++)
        {
            hexNumber[i] = binaryNumber.Substring(i * 4, 4);
            switch (hexNumber[i])
            {
                case "0000": hexNumber[i] = "0"; break;
                case "0001": hexNumber[i] = "1"; break;
                case "0010": hexNumber[i] = "2"; break;
                case "0011": hexNumber[i] = "3"; break;
                case "0100": hexNumber[i] = "4"; break;
                case "0101": hexNumber[i] = "5"; break;
                case "0110": hexNumber[i] = "6"; break;
                case "0111": hexNumber[i] = "7"; break;
                case "1000": hexNumber[i] = "8"; break;
                case "1001": hexNumber[i] = "9"; break;
                case "1010": hexNumber[i] = "A"; break;
                case "1011": hexNumber[i] = "B"; break;
                case "1100": hexNumber[i] = "C"; break;
                case "1101": hexNumber[i] = "D"; break;
                case "1110": hexNumber[i] = "E"; break;
                case "1111": hexNumber[i] = "F"; break;
            }
        }
        return hexNumber;
    }
}