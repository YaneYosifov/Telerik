namespace Calendar
{
    using System;
    using System.Globalization;
    using log4net;
    using log4net.Config;   

    internal static class CurrentMonth
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CurrentMonth));

        private static void Main()
        {
            XmlConfigurator.Configure();

            string month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            string padding = new string(' ', (21 - month.Length) / 2);
            Console.WriteLine("{0}{1}\n", padding, month);

            int count = 0;
            var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            switch (firstDayOfMonth.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    count = 1;
                    break;
                case DayOfWeek.Tuesday:
                    Console.Write(new string(' ', 3));
                    count = 2;
                    break;
                case DayOfWeek.Wednesday:
                    Console.Write(new string(' ', 6));
                    count = 3;
                    break;
                case DayOfWeek.Thursday:
                    Console.Write(new string(' ', 9));
                    count = 4;
                    break;
                case DayOfWeek.Friday:
                    Console.Write(new string(' ', 12));
                    count = 5;
                    break;
                case DayOfWeek.Saturday:
                    Console.Write(new string(' ', 15));
                    count = 6;
                    break;
                case DayOfWeek.Sunday:
                    Console.Write(new string(' ', 18));
                    count = 7;
                    break;
            }

            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                Console.Write("{0,3}", i);
                if (count == 7)
                {
                    Console.WriteLine();
                    count = 0;
                }

                count++;
            }

            Log.Info("Month successfully generated");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
