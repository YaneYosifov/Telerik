using System;
class PrintLongSequence
{
    static void Main()
    {
        int n = 2;
        for (int i = 0; i < 1000; i++)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                n++;
            }
            else
            {
                Console.WriteLine(n);
                n--;
            }

            n *= -1;
        }
    }
}