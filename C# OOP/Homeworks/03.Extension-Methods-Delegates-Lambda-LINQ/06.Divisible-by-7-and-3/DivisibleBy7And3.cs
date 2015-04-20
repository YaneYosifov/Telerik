/* Problem 6. Divisible by 7 and 3
 * Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 */

namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class DivisibleBy7And3
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                numbers.Add(i);
            }

            IEnumerable<int> resultLambda = numbers.Where(x => x % 3 == 0 && x % 7 == 0);
            Console.WriteLine("Result with lambda:\n{0}\n", string.Join(", ", resultLambda));

            IEnumerable<int> resultLinq =
                from number in numbers
                where number % 3 == 0 && number % 7 == 0
                select number;
            Console.WriteLine("Result with LINQ:\n{0}\n", string.Join(", ", resultLinq));

        }
    }
}
