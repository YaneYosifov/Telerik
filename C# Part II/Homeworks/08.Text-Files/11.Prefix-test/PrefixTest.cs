/*
 * Write a program that deletes from a text file 
 * all words that start with the prefix test.
 * Words contain only the symbols 0…9, a…z, A…Z, _.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
class PrefixTest
{
    static void Main()
    {
        StreamReader inputTxt = new StreamReader("LoremIpsum.txt");
        StreamWriter replaced = new StreamWriter("LoremIpsum_Output.txt");

        string text = inputTxt.ReadLine();
        while (text != null)
        {
            text = Regex.Replace(text, @"(?<!\w)test([a-zA-z0-9])", "".Replace("$", "$$"), RegexOptions.IgnoreCase);
            replaced.WriteLine(text);
            text = inputTxt.ReadLine();
        }

        inputTxt.Close();
        replaced.Close();

        File.Delete("LoremIpsum.txt");
        File.Move("LoremIpsum_Output.txt", "LoremIpsum.txt");
        // Working with large files too
    }
}