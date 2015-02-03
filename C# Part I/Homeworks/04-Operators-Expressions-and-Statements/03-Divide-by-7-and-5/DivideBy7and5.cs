using System;
class DivideBy7and5
{
    static void Main()
    {
        // * Write a Boolean expression that checks for given integer 
        //   if it can be divided (without remainder) by 7 and 5 at the same time.

        int n = int.Parse(Console.ReadLine());

        if (n != 0 && n % 5 == 0 && n % 7 == 0)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}