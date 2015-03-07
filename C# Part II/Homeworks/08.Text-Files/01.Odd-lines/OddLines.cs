/*
 * Write a program that reads a text file 
 * and prints on the console its odd lines.
 */

using System;
using System.IO;
class OddLines
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("Sample.txt");
        for (int i = 1; i < lines.Length; i += 2)
        {
            Console.WriteLine(lines[i]);
        }
    }
}