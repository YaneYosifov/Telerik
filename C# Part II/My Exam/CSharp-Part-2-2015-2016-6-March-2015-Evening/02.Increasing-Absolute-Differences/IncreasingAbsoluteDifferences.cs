using System;
using System.Linq;
class IncreasingAbsoluteDifferences
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        string[] inputNumbersArr = new string[t];
        bool isSeq = true;

        for (int i = 0; i < t; i++)
        {
            inputNumbersArr[i] = Console.ReadLine();
        }

        for (int i = 0; i < inputNumbersArr.Length; i++)
        {
            int[] currLine = inputNumbersArr[i].Split().Select(int.Parse).ToArray();
            int[] lineResult = new int[currLine.Length - 1];
            for (int j = 0; j < currLine.Length - 1; j++)
            {
                if ((currLine[j] <= 0 && currLine[j + 1] >= 0) || (currLine[j] >= 0 && currLine[j] <= 0))
                {
                    lineResult[j] = Math.Abs(currLine[j]) + Math.Abs(currLine[j + 1]);
                }
                else if (Math.Abs(currLine[j]) > Math.Abs(currLine[j + 1]))
                {
                    lineResult[j] = Math.Abs(currLine[j]) - Math.Abs(currLine[j + 1]);
                }
                else
                {
                    lineResult[j] = Math.Abs(currLine[j + 1]) - Math.Abs(currLine[j]);
                }
            }

            for (int j = 0; j < lineResult.Length - 1; j++)
            {
                if (lineResult[j] <= lineResult[j + 1] 
                    && (lineResult[j + 1] - lineResult[j] == 0 || lineResult[j + 1] - lineResult[j] == 1))
                {
                    continue;
                }
                else
                {
                    isSeq = false;
                    break;
                }
            }
            Console.WriteLine(isSeq);
            isSeq = true;
        }
    }
}