using System;
class NumberComparer
{
    static void Main()
    {
        // * Write a program that gets two numbers from the console 
        //   and prints the greater of them.
        // * Try to implement this without if statements.

        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine(a + " is greater");
        }
        else if (b > a)
        {
            Console.WriteLine(b + " is greater");
        }
        else
        {
            Console.WriteLine(a + " equals " + b);
        }
    }
}