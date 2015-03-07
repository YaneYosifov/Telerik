/*
 * Write a program that reads a year from the console 
 * and checks whether it is a leap one.
 * Use System.DateTime.
 */

using System;
class LeapYear
{
    static void Main()
    {
        Console.Write("Enter an year: ");
        DateTime yearInput = new DateTime(int.Parse(Console.ReadLine()), 1, 1);
        int year = yearInput.Year;
        Console.WriteLine("Is {0} leap year? {1}", year, DateTime.IsLeapYear(year));
    }
}