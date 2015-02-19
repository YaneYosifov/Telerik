/*
 * You are given an array of strings. Write a method that sorts the array 
 * by the length of its elements (the number of characters composing them).
 */

using System;
using System.Linq;
class SortByStringLength
{
    static void Main()
    {
        string[] words = { "sequence ", "class", "multiplying ", "program ", "size", "rectangular" };
        SortStringsByLength(words);
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }

    static void SortStringsByLength(string[] randWords)
    {
        Array.Sort(randWords, (x1, x2) => x1.Length.CompareTo(x2.Length));
    }
}