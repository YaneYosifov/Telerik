using System;

// Task 7
public class GSMTest
{
    public static void TestGSM()
    {
        GSMMain.phones[0] = new GSM("Galaxy S III", "Samsung", 600.50m, "Marry Jane", "LiIon", 330, 6.7, BatteryType.LiIon, 4.8, 16000000, null);
        GSMMain.phones[1] = new GSM("Xperia Z4", "Sony", 1250.00m, "John Doe", "LiIon", 240.3, 5, BatteryType.LiIon, 5.2, 16000000, null);

        GSMMain.phones[2] = GSM.IPhone4S;

        foreach (var phone in GSMMain.phones)
        {
            Console.WriteLine(phone);
            Console.WriteLine();
        }
    }
}