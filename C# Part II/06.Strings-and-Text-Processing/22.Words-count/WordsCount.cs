/*
 * Write a program that reads a string from the console 
 * and lists all different words in the string along 
 * with information how many times each word is found.
 */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class WordsCount
{
    static Dictionary<string, int> CountWords(string text)
    {
        Dictionary<string, int> dict =
            new Dictionary<string, int>();
        var matches = Regex.Matches(text, @"\w+");
        int count = 1;
        foreach (Match match in matches)
        {
            if (match.Success)
            {
                string word = match.Value;
                if (!dict.TryGetValue(word, out count))
                    dict.Add(word, 1);
                else
                    dict[word] = count + 1;
            }
        }
        return dict;
    }
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        foreach (var word in CountWords(text))
        {
            Console.WriteLine("{0} - {1} times", word.Key, word.Value);
        }
    }
}