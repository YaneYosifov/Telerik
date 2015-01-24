using System;
class SumOf3Numbers
{
    static void Main()
    {
        // * Write a program that reads 3 real numbers 
        //   from the console and prfloats their sum.

        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine(a + b + c);
    }
}