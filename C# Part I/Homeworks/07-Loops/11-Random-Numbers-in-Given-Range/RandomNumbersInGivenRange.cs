using System;
class RandomNumbersInGivenRange
{
    static void Main()
    {
        // * Write a program that enters 3 integers n, min and max (min != max) 
        //   and prints n random numbers in the range [min...max].

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            int randInt = rand.Next(min, max + 1);
            Console.WriteLine("{0} ", randInt);
        }
    }
}