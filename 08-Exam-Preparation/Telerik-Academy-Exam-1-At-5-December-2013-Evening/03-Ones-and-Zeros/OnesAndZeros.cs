using System;
class OnesAndZeros
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        // long remainder;
        // string result = string.Empty;
        // while (n > 0)
        // {
        //     remainder = n % 2;
        //     n /= 2;
        //     result = remainder.ToString() + result;
        // }
        //   
        // Console.WriteLine(result.PadLeft(16, '0'));


        for (int p = 15; p >= 0; p--)
        {
            long mask = 1 << p;
            long bit = (n & mask) >> p;

            if (bit == 0 && p != 0)
            {
                Console.Write("###.");
            }
            else if (bit == 1 && p != 0)
            {
                Console.Write(".#..");
            }
            else if (bit == 0 && p == 0)
            {
                Console.Write("###");
            }
            else if (bit == 1 && p == 0)
            {
                Console.Write(".#.");
            }
        }
        Console.WriteLine();

        for (int p = 15; p >= 0; p--)
        {
            long mask = 1 << p;
            long bit = (n & mask) >> p;

            if (bit == 0 && p != 0)
            {
                Console.Write("#.#.");
            }
            else if (bit == 1 && p != 0)
            {
                Console.Write("##..");
            }
            else if (bit == 0 && p == 0)
            {
                Console.Write("#.#");
            }
            else if (bit == 1 && p == 0)
            {
                Console.Write("##.");
            }
        }
        Console.WriteLine();

        for (int p = 15; p >= 0; p--)
        {
            long mask = 1 << p;
            long bit = (n & mask) >> p;

            if (bit == 0 && p != 0)
            {
                Console.Write("#.#.");
            }
            else if (bit == 1 && p != 0)
            {
                Console.Write(".#..");
            }
            else if (bit == 0 && p == 0)
            {
                Console.Write("#.#");
            }
            else if (bit == 1 && p == 0)
            {
                Console.Write(".#.");
            }
        }
        Console.WriteLine();

        for (int p = 15; p >= 0; p--)
        {
            long mask = 1 << p;
            long bit = (n & mask) >> p;

            if (bit == 0 && p != 0)
            {
                Console.Write("#.#.");
            }
            else if (bit == 1 && p != 0)
            {
                Console.Write(".#..");
            }
            else if (bit == 0 && p == 0)
            {
                Console.Write("#.#");
            }
            else if (bit == 1 && p == 0)
            {
                Console.Write(".#.");
            }
        }
        Console.WriteLine();

        for (int p = 15; p >= 0; p--)
        {
            long mask = 1 << p;
            long bit = (n & mask) >> p;

            if (bit == 0 && p != 0)
            {
                Console.Write("###.");
            }
            else if (bit == 1 && p != 0)
            {
                Console.Write("###.");
            }
            else if (bit == 0 && p == 0)
            {
                Console.Write("###");
            }
            else if (bit == 1 && p == 0)
            {
                Console.Write("###");
            }
        }
        Console.WriteLine();
    }
}