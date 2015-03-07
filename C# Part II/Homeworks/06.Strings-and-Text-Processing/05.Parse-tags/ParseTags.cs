/*
 * You are given a text. Write a program that changes the text in all 
 * regions surrounded by the tags <upcase> and </upcase> to upper-case.
 * The tags cannot be nested.
 */

using System;
class ParseTags
{
    static string ToUpcase(string text)
    {
        int startTag = 0;
        int endTag = 0;

        for (int i = 0; i < text.Length; i++)
        {
            i = text.IndexOf("<upcase>");
            startTag = i;
            i = text.IndexOf("</upcase>");
            endTag = i;

            if (i == -1)
            {
                break;
            }

            string upcaseText = text.Substring(startTag + 8, endTag - startTag - 8).ToUpper();
            text = text
                .Remove(startTag, endTag + 9 - startTag)
                .Insert(startTag, upcaseText);
        }

        return text;
    }
    static void Main()
    {
        Console.Write("Enter a text with <upcase></upcase> tags: ");
        string text = Console.ReadLine();
        Console.WriteLine("Formatted text: {0}", ToUpcase(text));
    }
}