using System;
using System.Linq;
using System.Numerics;
class TwoGirlsOnePath
{
    static void Main()
    {
        long[] flowers = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long mollyIndex = 0;
        long dollyIndex = flowers.Length - 1;

        BigInteger mollyFlowersSum = flowers[0];
        BigInteger dollyFlowersSum = flowers[flowers.Length - 1];

        long mollyFlowersInCell = flowers[0];
        long dollyFlowersInCell = flowers[flowers.Length - 1];

        flowers[0] = 0;
        flowers[flowers.Length - 1] = 0;

        for (long i = 0; i < flowers.Length; i++)
        {
            mollyIndex += mollyFlowersInCell;
            while (mollyIndex > flowers.Length - 1)
            {
                mollyIndex -= flowers.Length;
            }

            dollyIndex -= dollyFlowersInCell;
            while (dollyIndex < 0)
            {
                dollyIndex = flowers.Length - (-dollyIndex);
            }

            mollyFlowersInCell = flowers[mollyIndex];
            dollyFlowersInCell = flowers[dollyIndex];

            if (mollyIndex != dollyIndex)
            {
                mollyFlowersSum += mollyFlowersInCell;
                dollyFlowersSum += dollyFlowersInCell;
                flowers[mollyIndex] = 0;
                flowers[dollyIndex] = 0;
            }
            else
            {
                if (mollyFlowersInCell % 2 == 0)
                {
                    mollyFlowersSum += mollyFlowersInCell / 2;
                    dollyFlowersSum += dollyFlowersInCell / 2;
                    flowers[mollyIndex] = 0;
                }
                else
                {
                    mollyFlowersSum += mollyFlowersInCell / 2;
                    dollyFlowersSum += dollyFlowersInCell / 2;
                    flowers[mollyIndex] = 1;
                }
            }

            if (mollyFlowersInCell == 0 && dollyFlowersInCell == 0)
            {
                Console.WriteLine("Draw");
                break;
            }
            else if (mollyFlowersInCell == 0)
            {
                Console.WriteLine("Dolly");
                break;
            }
            else if (dollyFlowersInCell == 0)
            {
                Console.WriteLine("Molly");
                break;
            }
        }

        Console.WriteLine("{0} {1}", mollyFlowersSum, dollyFlowersSum);
    }
}