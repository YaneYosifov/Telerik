/*
 * Write a program that reads a text file containing a list of strings, 
 * sorts them and saves them to another text file.
 */

using System;
using System.IO;
class SaveSortedNames
{
    static void Main()
    {
        StreamReader input = new StreamReader("input.txt");
        string[] names = input.ReadToEnd().Split(new[] { " ", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(names);

        StreamWriter output = new StreamWriter("output.txt");
        for (int i = 0; i < names.Length; i++)
        {
            output.WriteLine(names[i]);
        }

        input.Close();
        output.Close();
    }
}