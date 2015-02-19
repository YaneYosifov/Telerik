/*
 * Write a program that can solve these tasks:
 * Reverses the digits of a number
 * Calculates the average of a sequence of integers
 * Solves a linear equation a * x + b = 0
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 * Validate the input data:
 * The decimal number should be non-negative
 * The sequence should not be empty
 * a should not be equal to 0
 */

using System;
using System.Linq;
class SolveTasks
{
    static int ReverseNum(int number)
    {
        int[] numArr = Array.ConvertAll(number.ToString().ToArray(), x => (int)x - 48);
        Array.Reverse(numArr);
        int result = numArr
            .Select((t, i) => t * Convert.ToInt32(Math.Pow(10, numArr.Length - i - 1)))
            .Sum();

        return result;
    }

    static int CalcAverage(int[] sequence)
    {
        int average = (int)sequence.Average();
        return average;
    }

    static double LinearEquation(double a, double b)
    {
        double x = -b / a;
        return x;
    }
    static void Main()
    {
        Console.WriteLine("1 --> Reverses the digits of a number");
        Console.WriteLine("2 --> Calculates the average of a sequence of integers");
        Console.WriteLine("3 --> Solves a linear equation a * x + b = 0");
        Console.Write("\nEnter your choise 1/2/3 : ");
        int choise = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choise)
        {
            case 1:
                int num;
                do
                {
                    Console.Write("Enter a non-negative number: ");
                    num = int.Parse(Console.ReadLine());
                } while (num < 0);
                Console.WriteLine("Reversed: {0}\n", ReverseNum(num));
                break;
            case 2:
                string inputStr = string.Empty;
                string[] inputSplit;
                do
                {
                    Console.WriteLine("Enter the numbers of sequence, separated by a space:");
                    inputStr = Console.ReadLine();
                    inputSplit = inputStr.Split();
                } while (inputSplit[0] == string.Empty);
                int[] nums = Array.ConvertAll(inputSplit, int.Parse);
                Console.WriteLine("Average number is {0}\n", CalcAverage(nums));
                break;
            case 3:
                double a;
                do
                {
                    Console.Write("a = ");
                    a = int.Parse(Console.ReadLine());
                } while (a == 0);
                Console.Write("b = ");
                double b = int.Parse(Console.ReadLine());
                Console.WriteLine("a * x + b = {0}\n", LinearEquation(a, b));
                break;
            default:
                break;
        }

    }
}