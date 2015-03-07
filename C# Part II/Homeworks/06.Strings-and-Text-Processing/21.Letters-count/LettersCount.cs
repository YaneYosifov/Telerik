/*
 * Write a program that reads a string from the console 
 * and prints all different letters in the string along 
 * with information how many times each letter is found.
 */

using System;
class LettersCount
{
    static int[] countChars(string input)
    {
        int[] countLetters = new int[65536];
        for (int i = 0; i < input.Length; i++)
        {
            char letter = input[i];
            countLetters[letter]++;
        }
        return countLetters;
    }

    static void PrintChars(int[] countLetters)
    {
        for (int i = 0; i < countLetters.Length; i++)
        {
            if (countLetters[i] != 0)
            {
                Console.WriteLine("'{0}' - {1} times", (char)i, countLetters[i]);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();
        PrintChars(countChars(userInput));
    }
}