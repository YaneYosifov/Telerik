/*
 * Write a program that replaces all occurrences of the sub-string start 
 * with the sub-string finish in a text file.
 * Ensure it will work with large files (e.g. 100 MB).
 */

using System;
using System.IO;
class ReplaceSubstring
{

    static void Main()
    {
        StreamReader inputTxt = new StreamReader("StartFinish.txt");
        StreamWriter replaced = new StreamWriter("StartFinish_Output.txt");

        string text = inputTxt.ReadLine();
        while (text != null)
        {
            text = text.Replace("start", "finish");
            replaced.WriteLine(text);
            text = inputTxt.ReadLine();
        }

        inputTxt.Close();
        replaced.Close();

        File.Delete("StartFinish.txt");
        File.Move("StartFinish_Output.txt", "StartFinish.txt");
        // Working with large files too
    }
}