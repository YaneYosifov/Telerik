using System;
class ThirdDigitIs7
{
    static void Main()
    {
        // * Write an expression that checks for given integer 
        //   if its third digit from right-to-left is 7.

        int n = int.Parse(Console.ReadLine());
        n = (n / 100) % 10;
        if (n == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}