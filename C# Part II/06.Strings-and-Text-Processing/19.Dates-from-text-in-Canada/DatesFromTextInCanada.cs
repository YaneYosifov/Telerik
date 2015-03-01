/*
 * Write a program that extracts from a given text 
 * all dates that match the format DD.MM.YYYY.
 * Display them in the standard date format for Canada.
 */

using System;
using System.Globalization;
class DatesFromTextInCanada
{
    static void Main()
    {
        Console.Write("Enter some text with dates within: ");
        string[] delimiters = { ". ", ",", "?", "!", ":", ";", "/", "(", ")", " " };
        string[] input = Console.ReadLine()
            .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        DateTime canadaDate;
        for (int i = 0; i < input.Length; i++)
        {
            if (DateTime.TryParseExact(input[i], "d.m.yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out canadaDate))
            {
                Console.WriteLine(input[i].ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }
}