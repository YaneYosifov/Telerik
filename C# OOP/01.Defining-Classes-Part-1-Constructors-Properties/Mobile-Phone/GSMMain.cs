using System;

public class GSMMain
{
    public static GSM[] phones = new GSM[3];
    public static void Main()
    {
        GSMTest.TestGSM();

        GSMCallHistoryTest.CreateCalltestHistory();

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Call history");
        Console.WriteLine(new string('-', 50));
        GSMCallHistoryTest.DisplayCalltestHistory();

        Console.WriteLine(new string('-', 50));
        Console.Write("Total price of test calls: ");
        GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();

        GSMCallHistoryTest.RemoveLongestCall();
        Console.WriteLine();
        Console.Write("Price after the longest call is removed: ");
        GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();

        Console.WriteLine();
        Console.WriteLine("Call history after the longest call is removed");
        Console.WriteLine(new string('-', 50));

        GSMCallHistoryTest.DisplayCalltestHistory();

        Console.WriteLine(new string('-', 50));
        GSMCallHistoryTest.testGSM.ClearCallHistory();
        Console.WriteLine("Call history list is cleared");
        Console.WriteLine(new string('-', 50));

        GSMCallHistoryTest.DisplayCalltestHistory();
    }
}