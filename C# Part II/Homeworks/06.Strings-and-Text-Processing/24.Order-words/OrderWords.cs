﻿/*
 * Write a program that reads a list of words, separated by spaces 
 * and prints the list in an alphabetical order.
 */

using System;
class OrderWords
{
    static void Main()
    {
        Console.Write("Enter a list of words, separated by spaces: ");
        string[] words = Console.ReadLine().Split();
        Array.Sort(words);
        Console.WriteLine(string.Join("\n", words));
    }
}