/* Problem 2. IEnumerable extensions
 * Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */

namespace IEnumerableExtensions
{
    using System.Collections.Generic;
    using System.Linq;
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> input)
        {
            T sum = default(T);
            foreach (var val in input)
            {
                sum += (dynamic)val;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> input)
        {
            T product = default(T) + (dynamic)1;
            foreach (var val in input)
            {
                product *= (dynamic)val;
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> input)
        {
            return input.Min(x => x);
        }
        public static T Max<T>(this IEnumerable<T> input)
        {
            return input.Max(x => x);
        }
        public static T Average<T>(this IEnumerable<T> input)
        {
            T avg = input.Sum() / (dynamic)input.Count();
            return avg;
        }

    }
}
