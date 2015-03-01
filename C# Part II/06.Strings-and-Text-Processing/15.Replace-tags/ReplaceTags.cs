/*
 * Write a program that replaces in a HTML document given as string 
 * all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a HTML code: ");
        string html = Console.ReadLine();
        html = html.Replace("<a href=\"", "[URL=");
        html = html.Replace("\">", "]");
        html = html.Replace("</a>", "[/URL]");

        Console.WriteLine(html);
    }
}