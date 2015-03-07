/*
 * Write a program that reads a date and time given in the format: 
 * day.month.year hour:minute:second and prints the date and time 
 * after 6 hours and 30 minutes (in the same format) 
 * along with the day of week in Bulgarian.
 */

using System;
using System.Globalization;
class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Enter a date and time in format day.month.year hour:minute:second");
        DateTime dateTime = DateTime.Parse(Console.ReadLine())
            .AddHours(6)
            .AddMinutes(30);

        var culture = new System.Globalization.CultureInfo("bg-BG");
        var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
        Console.WriteLine(dateTime);
        Console.WriteLine(dayOfWeek);
    }
}