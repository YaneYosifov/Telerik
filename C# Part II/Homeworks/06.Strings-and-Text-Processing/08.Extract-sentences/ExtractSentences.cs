/*
 * Write a program that extracts from a given text 
 * all sentences containing given word.
Example:

The word is: in
The text is: We are living in a yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day. 
We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. 
We will move out of it in 5 days.

Consider that the sentences are separated by . 
and the words – by non-letter symbols.
 */

using System;
using System.Collections.Generic;
class ExtractSentences
{
    static List<string> SentencesExtract(string text, string word)
    {
        List<string> splittedText = new List<string>
            (text.Split(new string[] {". "}, StringSplitOptions.RemoveEmptyEntries));
        for (int i = 0; i < splittedText.Count; i++)
        {
            if (splittedText[i].IndexOf(string.Format(" {0} ", word)) == -1)
            {
                splittedText.Remove(splittedText[i]);
                i--;
            }
        }
        return splittedText;
    }
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Enter a word to search: ");
        string word = Console.ReadLine();
        Console.WriteLine(string.Join(". ", SentencesExtract(text, word)));
    }
}