/*
 * Write a method that calculates the number of workdays 
 * between today and given date, passed as parameter.
 * Consider that workdays are all days from Monday to Friday 
 * except a fixed list of public holidays specified preliminary as array.
 */

using System;
using System.Globalization;
static class Workdays
{
    /// Calculates number of business days, taking into account:
    ///  - weekends (Saturdays and Sundays)
    ///  - bank holidays in the middle of the week
    ///
    /// firstDay - First day in the time interval
    /// lastDay - Last day in the time interval
    /// bankHolidays - List of bank holidays excluding weekends
    /// return - Number of business days during the 'span'
    static int BusinessDaysUntil(this DateTime firstDay, DateTime lastDay, params DateTime[] bankHolidays)
    {
        firstDay = firstDay.Date;
        lastDay = lastDay.Date;

        TimeSpan span = lastDay - firstDay;
        int businessDays = span.Days + 1;
        int fullWeekCount = businessDays / 7;
        // find out if there are weekends during the time exceedng the full weeks
        if (businessDays > fullWeekCount * 7)
        {
            // we are here to find out if there is a 1-day or 2-days weekend
            // in the time interval remaining after subtracting the complete weeks
            int firstDayOfWeek = (int)firstDay.DayOfWeek;
            int lastDayOfWeek = (int)lastDay.DayOfWeek;
            if (lastDayOfWeek < firstDayOfWeek)
                lastDayOfWeek += 7;
            if (firstDayOfWeek <= 6)
            {
                if (lastDayOfWeek >= 7) // Both Saturday and Sunday are in the remaining time interval
                    businessDays -= 2;
                else if (lastDayOfWeek >= 6) // Only Saturday is in the remaining time interval
                    businessDays -= 1;
            }
            else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7) // Only Sunday is in the remaining time interval
                businessDays -= 1;
        }

        // subtract the weekends during the full weeks in the interval
        businessDays -= fullWeekCount + fullWeekCount;

        // subtract the number of bank holidays during the time interval
        foreach (DateTime bankHoliday in bankHolidays)
        {
            DateTime bh = bankHoliday.Date;
            if (firstDay <= bh && bh <= lastDay)
                --businessDays;
        }

        return businessDays;
    }
    static void Main()
    {
        DateTime start = DateTime.Now;
        DateTime end;
        do
        {
            Console.WriteLine("Enter a date: ");
            string inputEnd = Console.ReadLine();
            end = Convert.ToDateTime(inputEnd);
            if (start > end)
            {
                Console.WriteLine("Date should be bigger than today\n");
            }
        } while (start > end);

        DateTime[] publicHolidays = new DateTime[]
            {
                new DateTime(end.Year, 1, 1),
                new DateTime(end.Year, 1, 2),
                new DateTime(end.Year, 3, 3),
                new DateTime(end.Year, 5, 1),
                new DateTime(end.Year, 5, 6),
                new DateTime(end.Year, 5, 24),
                new DateTime(end.Year, 9, 6),
                new DateTime(end.Year, 9, 22),
                new DateTime(end.Year, 11, 1),
                new DateTime(end.Year, 12, 24),
                new DateTime(end.Year, 12, 25),
                new DateTime(end.Year, 12, 26),
            };

        Console.WriteLine("Workdays from {0} until {1} are {2}", 
            DateTime.Now.ToString("d", CultureInfo.CreateSpecificCulture("bg-BG")),
            end.ToString("d", CultureInfo.CreateSpecificCulture("bg-BG")), 
            BusinessDaysUntil(start, end, publicHolidays));
    }
}