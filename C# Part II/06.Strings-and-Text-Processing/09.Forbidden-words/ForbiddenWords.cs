/*
 * We are given a string containing a list of forbidden words 
 * and a text containing some of these words.
 * Write a program that replaces the forbidden words with asterisks.

Example text: Microsoft announced its next generation PHP compiler today. 
It is based on .NET Framework 4.0 and is implemented 
as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler 
today. It is based on .NET Framework 4.0 and is implemented 
as a dynamic language in ***.
 */

using System;
class ForbiddenWords
{
    static string CensoredWords(string text, string[] forbiddenWords)
    {
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        return text;
    }
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Enter forbidden words, separated by a comma: ");
        string[] forbiddenWords = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine(string.Join(" ", CensoredWords(text, forbiddenWords)));
    }
}