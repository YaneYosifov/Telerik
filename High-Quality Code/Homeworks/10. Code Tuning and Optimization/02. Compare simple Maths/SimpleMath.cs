namespace MathPerformanceTest
{
    using System;
    using System.Diagnostics;

    public class SimpleMath
    {
        public static void Main()
        {
            const int INT = 0;
            ComparePerformance(INT);

            const long LONG = 0L;
            ComparePerformance(LONG);

            const float FLOAT = 0f;
            ComparePerformance(FLOAT);

            const double DOUBLE = 0;
            ComparePerformance(DOUBLE);

            const decimal DECIMAL = 0m;
            ComparePerformance(DECIMAL);
        }

        private static void ComparePerformance(dynamic count)
        {
            const int ITERATIONS = 100000000;

            Console.Write("{0, -25}", count.GetType() + " ++");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < ITERATIONS; i++)
                {
                    count++;
                }
            });

            Console.Write("{0, -25}", count.GetType() + " += 1");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < ITERATIONS; i++)
                {
                    count += 1;
                }
            });

            Console.Write("{0, -25}", count.GetType() + " --");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < ITERATIONS; i++)
                {
                    count--;
                }
            });

            Console.Write("{0, -25}", count.GetType() + " -= 1");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < ITERATIONS; i++)
                {
                    count -= 1;
                }
            });

            Console.Write("{0, -25}", count.GetType() + " *= 1");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < ITERATIONS; i++)
                {
                    count *= 1;
                }
            });

            Console.Write("{0, -25}", count.GetType() + " /= 1");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < ITERATIONS; i++)
                {
                    count /= 1;
                }
            });
        }

        private static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}