/*
 * Write a program for extracting all email addresses from given text.
 * All sub-strings that match the format 
 * <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;
using System.Text;
using System.Text.RegularExpressions;
class ExtractEmails
{
    static StringBuilder EmailExtractor(string[] text)
    {
        StringBuilder emails = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            if (Regex.Match(text[i],
            @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,2}[a-z0-9]))$").Success)
            {
                emails.Append(text[i] + "\n");
            }
        }
        return emails;
    }
    static void Main()
    {
        Console.Write("Enter a text which contains email addresses: ");
        string[] text = Console.ReadLine().Split();
        Console.WriteLine("\nExtracted emails:");
        Console.WriteLine(EmailExtractor(text));
    }
}