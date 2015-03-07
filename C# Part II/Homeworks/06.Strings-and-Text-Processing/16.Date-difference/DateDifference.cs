/*
 * Write a program that reads two dates in the format: 
 * day.month.year and calculates the number of days between them.
 */

using System;
class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter a dates in format day.month.year");
        Console.Write("First date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        double result = (firstDate - secondDate).TotalDays;
        Console.WriteLine("Distance: {0} days", Math.Abs(result));
    }
}