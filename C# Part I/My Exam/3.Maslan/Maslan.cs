using System;
using System.Linq;
class Maslan
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong length = (ulong)Math.Floor(Math.Log10(n) + 1);
        ulong[] digits = Array.ConvertAll(n.ToString().ToArray(), x => (ulong)x - 48);
        ulong[] sums = new ulong[length * length];

        ulong transformations = 0;
        ulong result = 0;

        for (uint counter = 0; counter <= sums.Length; counter++)
        {
            // 2.
            for (uint index = 0; index <= sums.Length; index++)
            {
                // removes the last digit
                digits = digits.Take(digits.Count() - 1).ToArray();

                // calculates the sum of all digits at odd positions
                for (uint i = 0; i < digits.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        sums[index] += (ulong)digits[i];
                    }
                }
            }

            // 7.
            // get the product of all sums found
            n = 1;

            for (uint i = 0; i < sums.Length; i++)
            {
                if (sums[i] == 0)
                {
                    sums[i] = 1;
                }
                n *= sums[i];
            }

            transformations++;
            result = n;

            if (transformations == 10)
            {
                Console.WriteLine(result);
                return;
            }

            length = (ulong)Math.Floor(Math.Log10(n) + 1);
            digits = Array.ConvertAll(n.ToString().ToArray(), x => (ulong)x - 48);
            sums = new ulong[length * length];
        }

        if (transformations < 10)
        {
            Console.WriteLine(transformations);
            Console.WriteLine(result);
        }
    }
}