/*
 * Write a program that compares two text files line by line 
 * and prints the number of lines that are the same 
 * and the number of lines that are different.
 * Assume the files have equal number of lines.
 */

using System;
using System.IO;
class CompareTextFiles
{
    static void Main()
    {
        StreamReader firstFile = new StreamReader("FirstFile.txt");
        StreamReader secondFile = new StreamReader("SecondFile.txt");

        string firstFileLine = firstFile.ReadLine();
        string secondFileLine = secondFile.ReadLine();
        while (firstFileLine != null)
        {
            firstFileLine = firstFile.ReadLine();
            secondFileLine = secondFile.ReadLine();
            if (firstFileLine == secondFileLine)
            {
                Console.WriteLine(firstFileLine);
            }
        }

        firstFile.Close();
        secondFile.Close();
    }
}