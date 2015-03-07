/*
 * Write a program that parses an URL address given in the format: 
 * [protocol]://[server]/[resource] and extracts from it the 
 * [protocol], [server] and [resource] elements.
 */

using System;
class ParseURL
{
    static void Main()
    {
        Console.Write("Enter and URL: ");
        string[] url = Console.ReadLine()
            .Split(new string[] { "://", "/" }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("[protocol] = {0}", url[0]);
        Console.WriteLine("[server] = {0}", url[1]);
        Console.WriteLine("[resource] = /{0}", string.Join("/", url, 2, url.Length - 2));
    }
}