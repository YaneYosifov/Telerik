/*
 * Write a program that finds the maximal increasing sequence in an array.
 */

using System;
using System.Collections.Generic;
class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers, separated by a comma:");
        string sequenceStr = Console.ReadLine();
        int[] sequenceArr = Array.ConvertAll(sequenceStr.Split(','), int.Parse);

        List<int> maxIncSequence = new List<int>();
        int indexStart = 0;
        int maxIndexStart = 0;
        int indexEnd = 0;
        int maxIndexEnd = 0;
        int tmpLength = 1;

        for (int i = 0; i < sequenceArr.Length - 1; i++)
        {
            maxIncSequence.Clear();
            maxIncSequence.Add(sequenceArr[i]);

            indexStart = i;
            while (i < sequenceArr.Length - 1 && sequenceArr[i] == sequenceArr[i + 1] - 1)
            {
                maxIncSequence.Add(sequenceArr[i + 1]);
                i++;
                tmpLength++;
            }
            indexEnd = i;

            if (tmpLength - 1 > maxIndexEnd - maxIndexStart)
            {
                maxIndexStart = indexStart;
                maxIndexEnd = indexEnd;
            }
            tmpLength = 1;
        }

        for (int i = maxIndexStart; i < maxIndexEnd; i++, maxIndexStart++)
        {
            Console.Write("{0}, ", sequenceArr[maxIndexStart]);
        }
        Console.WriteLine("{0}", sequenceArr[maxIndexStart]);
    }
}