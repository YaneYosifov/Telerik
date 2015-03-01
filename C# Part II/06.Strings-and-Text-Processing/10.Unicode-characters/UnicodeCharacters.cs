/*
 * Write a program that converts a string 
 * to a sequence of C# Unicode character literals.
 * Use format strings.
 */

using System;
using System.Text;
class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        char[] stringAsUnicode = Console.ReadLine().ToCharArray();
        foreach (char symbol in stringAsUnicode)
        {
            Console.Write(@"\u{0:X4}", (ushort)symbol);
        }
        Console.WriteLine();
    }
}