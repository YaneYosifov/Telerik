/*
 * Write a method that reverses the digits of given decimal number.
 */

using System;
using System.Linq;
class ReverseNumber
{
    static void Reverse(int[] num)
    {
        int[] reversed = new int[num.Length];
        for (int i = 0; i < num.Length; i++)
        {
            reversed[num.Length - i - 1] = num[i];
        }

        Console.WriteLine(string.Join("", reversed));
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int Input = int.Parse(Console.ReadLine());
        int[] number = Array.ConvertAll(Input.ToString().ToArray(), x => (int)x - 48);
        Console.Write("Reversed: ");
        Reverse(number);
    }
}