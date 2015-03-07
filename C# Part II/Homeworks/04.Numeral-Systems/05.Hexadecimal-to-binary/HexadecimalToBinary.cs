/*
 * Write a program to convert hexadecimal numbers to binary numbers (directly).
 */

using System;
class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine().ToUpper();
        Console.WriteLine("Converted to binary: {0}", string.Join("", HexToBinary(hexNumber)));
    }

    static string[] HexToBinary(string hexNumber)
    {
        string[] binaryNumber = new string[hexNumber.Length];
        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case '0': binaryNumber[i] = "0000"; break;
                case '1': binaryNumber[i] = "0001"; break;
                case '2': binaryNumber[i] = "0010"; break;
                case '3': binaryNumber[i] = "0011"; break;
                case '4': binaryNumber[i] = "0100"; break;
                case '5': binaryNumber[i] = "0101"; break;
                case '6': binaryNumber[i] = "0110"; break;
                case '7': binaryNumber[i] = "0111"; break;
                case '8': binaryNumber[i] = "1000"; break;
                case '9': binaryNumber[i] = "1001"; break;
                case 'A': binaryNumber[i] = "1010"; break;
                case 'B': binaryNumber[i] = "1011"; break;
                case 'C': binaryNumber[i] = "1100"; break;
                case 'D': binaryNumber[i] = "1101"; break;
                case 'E': binaryNumber[i] = "1110"; break;
                case 'F': binaryNumber[i] = "1111"; break;
            }
        }
        return binaryNumber;
    }
}