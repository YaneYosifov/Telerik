/*
 * Write a program that concatenates two text files into another text file.
 */

using System;
using System.IO;
class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader file1 = new StreamReader("Part1.txt");
            string file1Content = file1.ReadToEnd();
        StreamReader file2 = new StreamReader("Part2.txt");
            string file2Content = file2.ReadToEnd();
        StreamWriter concat = new StreamWriter("Concatenated.txt");
        concat.Write(file1Content + file2Content);
        file1.Close();
        file2.Close();
        concat.Close();
    }
}