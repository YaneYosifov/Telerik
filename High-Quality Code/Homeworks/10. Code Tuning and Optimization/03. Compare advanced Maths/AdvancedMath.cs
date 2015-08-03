namespace MathPerformanceTest
{
    using System;
    using System.Diagnostics;

    public class SimpleMath
    {
        public static void Main()
        {
            const float FLOAT = 1f;
            ComparePerformance(FLOAT);

            const double DOUBLE = 1;
            ComparePerformance(DOUBLE);

            const decimal DECIMAL = 1m;
            ComparePerformance(DECIMAL);
        }

        private static void ComparePerformance(dynamic count)
        {
            const int ITERATIONS = 15000000;

            Console.Write("{0, -25}", count.GetType() + " Sqrt");
            DisplayExecutionTime(() =>
            {
                if (count.GetType() == typeof(decimal))
                {
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        count += (decimal)Math.Sqrt((double)count);
                    }
                }
                else if (count.GetType() == typeof(float))
                {
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        count += (float)Math.Sqrt(count);
                    }
                }
                else
                {
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        count += Math.Sqrt(count);
                    }
                }
            });

            Console.Write("{0, -25}", count.GetType() + " Log");
            DisplayExecutionTime(() =>
            {
                if (count.GetType() == typeof(decimal))
                {
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        count += (decimal)Math.Log((double)count);
                    }
                }
                else if (count.GetType() == typeof(float))
                {
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        count += (float)Math.Log(count);
                    }
                }
                else
                {
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        count += Math.Log(count);
                    }
                }
            });

            Console.Write("{0, -25}", count.GetType() + " Sin");
            DisplayExecutionTime(() =>
            {
                if (count.GetType() == typeof(decimal))
                {
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        count += (decimal)Math.Sin((double)count);
                    }
                }
                else if (count.GetType() == typeof(float))
                {
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        count += (float)Math.Sin(count);
                    }
                }
                else
                {
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        count += Math.Sin(count);
                    }
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