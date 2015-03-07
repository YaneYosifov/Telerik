/*
 * Write a program that deletes from given text file all odd lines.
 * The result should be in the same file.
 */

using System;
using System.IO;
class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("testfile.txt");
        string[] text = reader.ReadToEnd().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        reader.Close();

        File.WriteAllText("testfile.txt", String.Empty);
        StreamWriter writer = new StreamWriter("testfile.txt", true);
        int index = 0;
        while (index < text.Length)
        {
            writer.WriteLine(text[index]);
            index += 2;
        }
        writer.Close();
    }
}