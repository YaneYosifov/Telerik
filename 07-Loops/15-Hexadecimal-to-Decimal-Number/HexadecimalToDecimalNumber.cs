using System;
using System.Text;
class HexadecimalToDecimalNumber
{
    static void Main()
    {
        // * Using loops write a program that converts 
        //   a hexadecimal integer number to its decimal form.
        // * The input is entered as string. 
        //   The output should be a variable of type long.
        // * Do not use the built-in .NET functionality.

        Console.Write("hexadecimal: ");
        string hex = Console.ReadLine();
        long number = 0;
        long power = 1;

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            int sign;
            switch (hex[i])
            {
                case 'A':
                case 'a': sign = 10;
                    break;
                case 'B':
                case 'b': sign = 11;
                    break;
                case 'C':
                case 'c': sign = 12;
                    break;
                case 'D':
                case 'd': sign = 13;
                    break;
                case 'E':
                case 'e': sign = 14;
                    break;
                case 'F':
                case 'f': sign = 15;
                    break;
                default: sign = hex[i] - 48;
                    break;
            }
            number += sign * power;
            power *= 16;
        }
        Console.WriteLine("decimal: {0}", number);
    }
}