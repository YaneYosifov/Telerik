using System;
using System.Text;
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        // * Using loops write a program that converts 
        //   an integer number to its hexadecimal representation.
        // * The input is entered as long. 
        //   The output should be a variable of type string.
        // * Do not use the built-in .NET functionality.

        Console.Write("decimal: ");
        long number = long.Parse(Console.ReadLine());
        string hexadecimal = string.Empty;
        long inputNumber = number;
        string[] hexes = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        while (number >= 16)
        {
            hexadecimal = hexes[(number % 16)] + hexadecimal;
            number /= 16;
        }

        hexadecimal = hexes[number] + hexadecimal;
        Console.WriteLine("hexadecimal: {0}", hexadecimal);
    }
}