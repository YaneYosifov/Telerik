namespace Statistics
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] numbers, int count)
        {
            double max = 0;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            PrintMax(max);

            double min = max;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            PrintMin(min);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }

            PrintAvg(sum / count);
        }
    }
}
