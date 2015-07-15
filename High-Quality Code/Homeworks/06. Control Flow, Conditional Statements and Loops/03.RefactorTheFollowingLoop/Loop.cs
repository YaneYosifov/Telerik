using System;

public class Loop
{
    public static void Main()
    {
        int devilCode = 0;
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(array[i]);
            if (i % 10 == 0 && array[i] == expectedValue)
            {
                devilCode = 666;
            }
        }

        // More code here
        if (devilCode == 666)
        {
            Console.WriteLine("Value Found");
        }
    }
}