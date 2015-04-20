/* Problem 2. IEnumerable extensions
 * Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    class Test
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 3, 8, 1, 11, 13, 9, 2 };
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Product());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Average());
        }
    }
}
