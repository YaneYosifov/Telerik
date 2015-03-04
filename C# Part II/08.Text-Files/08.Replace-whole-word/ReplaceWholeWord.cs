/*
 * Modify the solution of the previous problem 
 * to replace only whole words (not strings).
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
class ReplaceWholeWord
{
    static void Main()
    {
        StreamReader inputTxt = new StreamReader("StartFinish.txt");
        StreamWriter replaced = new StreamWriter("StartFinish_Output.txt");

        string text = inputTxt.ReadLine();
        while (text != null)
        {
            text = Regex.Replace(text, @"(?<!\w)start(?!\w)", "finish".Replace("$", "$$"), RegexOptions.IgnoreCase);
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