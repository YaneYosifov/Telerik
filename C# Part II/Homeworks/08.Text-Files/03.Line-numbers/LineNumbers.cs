/*
 * Write a program that reads a text file and inserts 
 * line numbers in front of each of its lines.
 * The result should be written to another text file.
 */

using System;
using System.IO;
class LineNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("TestFile.txt"))
        {
            using (StreamWriter writer =
                new StreamWriter("NumberedLines.txt"))
            {
                string line = reader.ReadLine();
                int counter = 1;
                while (line != null)
                {
                    writer.WriteLine(counter + ". " + line);
                    line = reader.ReadLine();
                    counter++;
                }
            }
        }
    }
}