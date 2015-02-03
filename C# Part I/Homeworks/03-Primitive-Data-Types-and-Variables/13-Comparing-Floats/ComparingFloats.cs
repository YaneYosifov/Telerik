using System;
class ComparingFloats
{
    static void Main()
    {
        // * Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
        // Note: Two floating-point numbers a and b cannot be compared directly by a == b 
        // because of the nature of the floating-point arithmetic. 
        // Therefore, we assume two numbers are equal if they are 
        // more closely to each other than a fixed constant eps.

        while (true)
        {
            Console.Write("Enter a first floating-point number: ");
            double double1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a second floating-point number: ");
            double double2 = double.Parse(Console.ReadLine());

            Console.WriteLine("a == b ?");
            Console.WriteLine(Math.Abs(double1 - double2) <= 0.000001);
            Console.WriteLine();
        }
    }
}
