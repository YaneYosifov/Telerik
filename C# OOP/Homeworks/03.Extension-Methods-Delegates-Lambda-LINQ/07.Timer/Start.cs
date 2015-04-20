/* Problem 7. Timer
 * Using delegates write a class Timer that can execute certain method at each t seconds.
 */

namespace Timer
{
    using System;

    class Start
    {
        private static void Test(string val)
        {
            Console.WriteLine("Test method --> {0}", val);
        }

        static void Main()
        {
            Timer t = new Timer(1);
            t.Method += Test;
            t.Start("Hi there!");
        }
    }
}
