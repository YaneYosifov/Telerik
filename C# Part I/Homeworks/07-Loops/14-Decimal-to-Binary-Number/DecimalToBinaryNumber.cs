using System;
class DecimalToBinaryNumber
{
    static void Main()
    {
        // * Using loops write a program that converts 
        //   an integer number to its binary representation.
        // * The input is entered as long. The output 
        //   should be a variable of type string.
        // * Do not use the built-in .NET functionality.

        Console.Write("decimal: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        long remainder;
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("binary: {0}", result);
    }
}