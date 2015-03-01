/*
 * Write a program that extracts from a given text 
 * all palindromes, e.g. ABBA, lamal, exe.
 */

using System;
using System.Collections.Generic;
using System.Linq;
class Palindromes
{
    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        Console.Write("Enter some text with palindromes to extract: ");
        string input = Console.ReadLine();
        string[] text = new string(input.Where(c => !char.IsPunctuation(c))
            .ToArray()).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in text)
        {
            if (IsPalindrome(word.ToLower()) == true)
            {
                Console.WriteLine(word);
            }
        }
    }
}