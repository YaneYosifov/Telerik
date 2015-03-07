/*
 * A dictionary is stored as a sequence of text lines 
 * containing words and their explanations.
 * Write a program that enters a word 
 * and translates it by using the dictionary.
 */

using System;
using System.Collections;
class WordDictionary
{
    static Hashtable Dictionary()
    {
        Hashtable dictionary = new Hashtable();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");
        return dictionary;
    }
    static void Main()
    {
        Console.Write("Enter a word to translate: ");
        string word = Console.ReadLine();
        Hashtable hashtable = Dictionary();
        string value = (string)hashtable[word];
        Console.WriteLine(value);
        Console.WriteLine();
        Main();
    }
}