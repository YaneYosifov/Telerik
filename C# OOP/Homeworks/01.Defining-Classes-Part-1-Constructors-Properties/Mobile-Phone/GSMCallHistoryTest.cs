using System;
using System.Linq;

// Task 12
public class GSMCallHistoryTest
{
    public static GSM testGSM = new GSM("TestGSM", "TestModel");

    public static DateTime testCall2Date = DateTime.Parse("08/03/2015 19:15:30");
    public static DateTime testCall3Date = DateTime.Parse("09/03/2015 14:07:18");
    public static DateTime testCall4Date = DateTime.Parse("10/03/2015 08:15:55");
    public static DateTime testCall5Date = DateTime.Parse("10/03/2015 12:37:03");
    public static DateTime testCall1Date = DateTime.Parse("10/03/2015 09:25:10");
    public static Call[] testCalls = 
        {
            new Call(testCall1Date, "0888111111", 30),
            new Call(testCall2Date, "0888222222", 40),
            new Call(testCall3Date, "0888333333", 50),
            new Call(testCall4Date, "0888444444", 60),
            new Call(testCall5Date, "0888555555", 100)
        };
    public static void CreateCalltestHistory()
    {
        for (int i = 0; i < testCalls.Length; i++)
        {
            testGSM.AddCall(testCalls[i]);
        }
    }

    public static void DisplayCalltestHistory()
    {
        for (int i = 0; i < testGSM.CallHistory.Count; i++)
        {
            Console.WriteLine("Date and time: {0}", testGSM.CallHistory[i].CallDateTime);
            Console.WriteLine("Phone number: {0}", testGSM.CallHistory[i].CalledNumber);
            Console.WriteLine("Call duration: {0}", testGSM.CallHistory[i].CallDuration);
            Console.WriteLine();
        }
    }
    public static void CalculateAndPrintTestcallsPrice()
    {
        decimal price = testGSM.CallPriceCalculate(0.37M);
        Console.WriteLine("{0:F2}", price);
    }
    public static void RemoveLongestCall()
    {
        Call longestCall = testGSM.CallHistory.OrderBy(x => x.CallDuration).ToArray()[testGSM.CallHistory.Count - 1];
        testGSM.RemoveCall(longestCall);
    }
}
