/*
 * Write a method ReadNumber(int start, int end) that enters 
 * an integer number in a given range [start…end].
 * If an invalid number or non-number text is entered, 
 * the method should throw an exception.
 * Using this method write a program that enters 10 numbers: 
 * a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;
class EnterNumbers
{
    static void ReadNumber(int start, int end)
    {
        try
        {
            Console.Write("Enter an integer number [{0}...{1}]: ", start, end);
            int num = int.Parse(Console.ReadLine());
            if (num < start && num > end)
            {
                throw new Exception();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter an integer number [{0} < a < 100]: ", num);
                int a = int.Parse(Console.ReadLine());
                if (num < a && a < 100)
                {
                    num = a;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    static void Main()
    {
        Console.Write("Enter a start integer number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter an end integer number: ");
        int end = int.Parse(Console.ReadLine());
        ReadNumber(start, end);
    }
}