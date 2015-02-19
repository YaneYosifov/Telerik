using System;
class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotOutside = n - 2;
        int dotInside = 1;

        /*
                    .....*.....
                    ....***....
                    ...*.*.*...
                    ..*..*..*..
                    .*...*...*.
                    ***********
                    .*...*...*.
                    ..*..*..*..
                    ...*****...
        */

        /*
                    .....*.....
                    ....***....
        */
        for (int i = 0; i < n; i++)
        {
            Console.Write(".");
        }
        Console.Write("*");
        for (int i = 0; i < n; i++)
        {
            Console.Write(".");
        }
        Console.WriteLine();
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(".");
        }
        Console.Write("***");
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(".");
        }
        Console.WriteLine();

        /*
                    ...*.*.*...
                    ..*..*..*..
                    .*...*...*.
        */

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < dotOutside; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int j = 0; j < dotInside; j++)
            {
                Console.Write("."); ;
            }
            Console.Write("*");
            for (int j = 0; j < dotInside; j++)
            {
                Console.Write("."); ;
            }
            Console.Write("*");
            for (int j = 0; j < dotOutside; j++)
            {
                Console.Write(".");
            }
            dotOutside--;
            dotInside++;
            Console.WriteLine();
        }

        /*
                        ***********
        */

        for (int i = 0; i < n * 2 + 1 ; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        /*
                        .*...*...*.
                        ..*..*..*..
        */

        dotOutside++;
        dotInside--;
        for (int i = 0; i < (6 + ((n - 3) / 2) * 3) / 3 - 1; i++)
        {
            for (int j = 0; j < dotOutside; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int j = 0; j < dotInside; j++)
            {
                Console.Write("."); ;
            }
            Console.Write("*");
            for (int j = 0; j < dotInside; j++)
            {
                Console.Write("."); ;
            }
            Console.Write("*");
            for (int j = 0; j < dotOutside; j++)
            {
                Console.Write(".");
            }
            dotOutside++;
            dotInside--;
            Console.WriteLine();
        }

        /*
                        ...*****...
         */

        for (int i = 0; i < dotOutside; i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < (n * 2 + 1) - dotOutside * 2; i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < dotOutside; i++)
        {
            Console.Write(".");
        }
        Console.WriteLine();
    }
}