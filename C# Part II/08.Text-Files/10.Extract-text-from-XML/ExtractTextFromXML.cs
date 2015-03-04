/*
 * Write a program that extracts from given XML file 
 * all the text without the tags.
Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
 */

using System;
using System.Text;
using System.IO;
class ExtractTextFromXML
{
    static void ExtractHTMLBody(string input)
    {
        StringBuilder bodyText = new StringBuilder();
        int textStart = 0;
        for (int i = textStart; i < input.Length - 1; i++)
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

            if (input[i] != '>' && input[i + 1] == '<')
            {
                bodyText.Append("\n");
            }
        }
        bodyText.Replace("\r\n", " ");
        bodyText.Replace("   ", " ").Replace("  ", " ");
        bodyText.Replace("   ", " ").Replace("  ", " ");

        Console.WriteLine("{0}", bodyText);
    }
    static void Main()
    {
        string input = File.ReadAllText("testfile.xml");
        ExtractHTMLBody(input);
    }
}