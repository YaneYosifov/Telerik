/*
 * Write a program that extracts from given HTML file its title 
 * (if available), and its body text without the HTML tags.
 */

using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
class ExtractTextFromHTML
{
    static void ExtractHTMLTitle(string input)
    {
        Match title = Regex.Match(input, @"<title>\s*(.+?)\s*</title>");
        if (title.Success)
        {
            Console.WriteLine("Title: {0}", title.Groups[1].Value);
        }
    }
    static void ExtractHTMLBody(string input)
    {
        StringBuilder bodyText = new StringBuilder();
        int textStart = input.IndexOf("<body>") + 6;
        for (int i = textStart; i < input.Length; i++)
        {
            if (input[i] == '<' || (input[i] == '<' && input[i + 1] == '/'))
            {
                while (input[i] != '>')
                {
                    i++;
                }
            }
            else
            {
                bodyText.Append(input[i]);
            }
        }
        bodyText.Replace("\r\n", " ");
        bodyText.Replace("   ", " ").Replace("  ", " ");
        bodyText.Replace("   ", " ").Replace("  ", " ");

        Console.WriteLine("Text: {0}", bodyText);
    }
    static void Main()
    {
        string input = File.ReadAllText(@"..\..\HTMLTest.html");

        ExtractHTMLTitle(input);
        ExtractHTMLBody(input);
    }
}