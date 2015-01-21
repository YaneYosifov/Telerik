using System;
class OddОrEvenIntegers
{
    static void Main()
    {
        // * Write an expression that checks if given integer is odd or even.

        int n = int.Parse(Console.ReadLine());
        bool p = n % 2 != 0 ? true : false;
        Console.WriteLine(p);
    }
}