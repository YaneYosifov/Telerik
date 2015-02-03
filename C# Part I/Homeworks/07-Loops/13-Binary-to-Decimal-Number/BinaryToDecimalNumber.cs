using System;
class BinaryToDecimalNumber
{
    static void Main()
    {
        // * Using loops write a program that converts 
        //   a binary integer number to its decimal form.
        // * The input is entered as string. 
        //   The output should be a variable of type long.
        // * Do not use the built-in .NET functionality.

        Console.Write("binary: ");
        var s = Console.ReadLine();
        long dec = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[s.Length - i - 1] == '0') continue;
            dec += (long)Math.Pow(2, i);
        }
        Console.WriteLine("decimal: {0}", dec);
    }
}