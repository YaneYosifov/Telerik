using System;
class CheckABitAtGivenPosition
{
    static void Main()
    {
        // * Write a Boolean expression that returns if 
        //   the bit at position p (counting from 0, starting from the right) 
        //   in given integer number n, has value of 1.

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int bit = (n & mask) >> p;

        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}