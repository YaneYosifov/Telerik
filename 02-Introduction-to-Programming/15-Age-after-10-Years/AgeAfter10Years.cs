using System;
class AgeAfter10Years
{
    static void Main()
    {
        string inputBday = Console.ReadLine();
        DateTime bday = Convert.ToDateTime(inputBday);

        DateTime now = DateTime.Now;
        int age = now.Year - bday.Year;

        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}