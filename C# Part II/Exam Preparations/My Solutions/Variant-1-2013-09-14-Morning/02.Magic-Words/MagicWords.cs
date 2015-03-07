using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
class MagicWords
{
    static List<string> Reorder(int n, List<string> words)
    {
        for (int i = 0; i < words.Count; i++)
        {
            int insertToPosition = words[i].Length % (n + 1);
            words.Insert(insertToPosition, words[i]);
            if (insertToPosition < i)
            {
                words.RemoveAt(i + 1);
            }
            else
            {
                words.RemoveAt(i);
            }
        }
        return words;
    }

    static void Print(List<string> wordsToPrint)
    {
        StringBuilder result = new StringBuilder();
        string longestWord = wordsToPrint.OrderByDescending(s => s.Length).First();
        for (int letter = 0; letter <= longestWord.Length; letter++)
        {
            for (int word = 0; word < wordsToPrint.Count; word++)
            {
                string extracterWord = wordsToPrint[word];
                if (letter < extracterWord.Length)
                {
                    char ch = extracterWord[letter];
                    result.Append(ch);
                }
            }
        }
        Console.WriteLine(result);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();

        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        List<string> reordered = Reorder(n, words);
        Print(reordered);
    }
}