namespace Methods
{
    using System;

    public class EntryPoint
    {
        private static void Main()
        {
            Console.WriteLine(Utility.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Utility.NumberToDigit(5));

            Console.WriteLine(Utility.FindMax(5, -1, 3, 2, 14, 2, 3));

            Utility.PrintAsNumber(1.3, "f");
            Utility.PrintAsNumber(0.75, "%");
            Utility.PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(Utility.CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
