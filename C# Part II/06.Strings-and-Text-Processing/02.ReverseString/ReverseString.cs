/*
 * Write a program that reads a string, 
 * reverses it and prints the result at the console.
 */

using System;
using System.Text;
class ReverseString
{
    static string ReverseIt(string str)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed.Append(str[i]);
        }
        return reversed.ToString();
    }
    static void Main()
    {
        Console.Write("Enter a string: ");
        string toReverse = Console.ReadLine();
        Console.WriteLine("Reversed: {0}", ReverseIt(toReverse));
    }
}