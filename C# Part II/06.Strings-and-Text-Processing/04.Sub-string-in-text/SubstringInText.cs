/*
 * Write a program that finds how many times a sub-string 
 * is contained in a given text (perform case insensitive search).
 */

using System;
class SubstringInText
{
    static int FindSubString(string text, string substring)
    {
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            i = text.IndexOf(substring, i);
            if (i == -1)
            {
                break;
            }
            count++;
        }
        return count;
    }
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Enter a sub-string to search: ");
        string substring = Console.ReadLine().ToLower();

        Console.WriteLine("{0} times", FindSubString(text, substring));
    }
}