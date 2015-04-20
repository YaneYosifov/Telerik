/*Problem 1. StringBuilder.Substring
 * Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
 */

namespace StringBuilder.Substring
{
    using System;
    using System.Text;
    class Test
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder("OneTwoThree");
            Console.WriteLine(str.Substring(6, 5));
        }
    }
}
