using System;
class PrimeNumberCheck
{
    static void Main()
    {
        // * Write an expression that checks if given positive integer number n 
        //   (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

        int n = int.Parse(Console.ReadLine());
        for (int i = n-1; i > 1; i--)
        {
            if (n % i == 0)
            {
                Console.WriteLine(false);
                return;
            }
        }
        if (n <= 1)
        {
            Console.WriteLine(false);
            return;
        }
        Console.WriteLine(true);
    }
}