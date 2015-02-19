using System;
class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotLeft = 0;
        int dotInside = 0;
        int dotRight = 0;

/*                  .....***.....
                                                    */

        for (int i = 0; i < n + 1; i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < n + 1; i++)
        {
            Console.Write(".");
        }
        Console.WriteLine();

/*                  ...*.....*...
                                                    */

        for (int i = 0; i < n / 2 - 1; i++)
        {
            for (int j = n - dotLeft - 1; j > 0; j--)
            {
                Console.Write(".");
            }
            dotLeft += 2;
            Console.Write("*");

            for (int j = 0; j < n + 1 + dotInside; j++)
            {
                Console.Write(".");
            }
            dotInside += 4;
            Console.Write("*");

            for (int j = n - dotRight - 1; j > 0; j--)
            {
                Console.Write(".");
            }
            dotRight += 2;
            Console.WriteLine();
        }

/*
                    .*.........*.
                                                    */

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.Write(".*");
            for (int j = 0; j < n * 3 - 3; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine("*.");
        }

/*
                    .*@.@.@.@.@*.
                                                    */

        Console.Write(".*");
        for (int j = 0; j < n * 3 - 5; j += 2)
        {
            Console.Write("@.");
        }
        Console.WriteLine("@*.");

/*
                    .*.@.@.@.@.*.
                                                    */

        Console.Write(".*");
        for (int j = 0; j < n * 3 - 5; j += 2)
        {
            Console.Write(".@");
        }
        Console.WriteLine(".*.");

/*
                    .*.........*.
                                                     */

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.Write(".*");
            for (int j = 0; j < n * 3 - 3; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine("*.");
        }

/*
                    ...*.....*...
                                                     */

        for (int i = 0; i < n / 2 - 1; i++)
        {
            dotLeft -= 2;
            for (int j = n - dotLeft - 1; j > 0; j--)
            {
                Console.Write(".");
            }
            Console.Write("*");
            dotInside -= 4;

            for (int j = 0; j < n + 1 + dotInside; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            dotRight -= 2;

            for (int j = n - dotRight - 1; j > 0; j--)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

/*                  .....***.....
                                                    */

        for (int i = 0; i < n + 1; i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < n + 1; i++)
        {
            Console.Write(".");
        }
        Console.WriteLine();
    }
}