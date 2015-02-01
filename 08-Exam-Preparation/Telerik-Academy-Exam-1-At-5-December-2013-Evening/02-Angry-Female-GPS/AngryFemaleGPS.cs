using System;
class AngryFemaleGPS
{
    static void Main()
    {
        long n = Math.Abs(long.Parse(Console.ReadLine()));
        int even = 0;
        int odd = 0;

        int length = (int)Math.Floor(Math.Log10(Math.Abs(n)) + 1);

        for (int i = 0; i < length; i++)
        {
            if ((n % 10) % 2 == 0)
            {
                even += (int)(n % 10);
            }
            else
            {
                odd += (int)(n % 10);
            }

            n /= 10;
        }

        if (even > odd)
        {
            Console.WriteLine("right {0}", even);
        }
        else if (odd > even)
        {
            Console.WriteLine("left {0}", odd);
        }
        else
        {
            Console.WriteLine("straight {0}", even);
        }
    }
}