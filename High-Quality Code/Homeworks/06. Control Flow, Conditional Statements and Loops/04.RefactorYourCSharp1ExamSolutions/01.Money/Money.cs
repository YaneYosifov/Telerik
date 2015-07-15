namespace Exam
{
    using System;

    public class Money
    {
        public static void Main()
        {
            double students = double.Parse(Console.ReadLine());
            double sheets = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double result = 0;

            result = ((students * sheets) / 400) * price;
            Console.WriteLine("{0:F3}", result);
        }
    }
}