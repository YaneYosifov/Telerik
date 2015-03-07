/*
 * Write a method GetMax() with two parameters 
 * that returns the larger of two integers.
 * Write a program that reads 3 integers from the console 
 * and prints the largest of them using the method GetMax().
 */

using System;
class GetLargestNumber
{
    static int GetMax(int first, int second)
    {
        int larger;
        if (first > second)
        {
            larger = first;
        }
        else
        {
            larger = second;
        }
        return larger;
    }
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int x3 = int.Parse(Console.ReadLine());

        int larger = GetMax(x1, x2);
        int largest = GetMax(larger, x3);
        Console.WriteLine("The largest numbers is {0}", largest);
    }
}
