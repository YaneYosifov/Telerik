/*
 * Write a program that creates an array 
 * containing all letters from the alphabet (A-Z).
 * Read a word from the console and print 
 * the index of each of its letters in the array.
 */

using System;
class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[52];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i + 65);
        }

        for (int i = 26; i < 52; i++)
        {
            alphabet[i] = (char)(i + 97 - 26);
        }

        Console.Write("Enter a word (A-Z, a-z): ");
        char[] word = Console.ReadLine().ToCharArray();

        for (int i = 0; i < word.Length; i++)
        {
            int letter = Array.BinarySearch(alphabet, word[i]);
            Console.WriteLine("Letter '{0}' in the word has index [{1}] "
                + "in the alphabet array", (char)word[i], letter);
        }
    }
}