/*
 * Write a program that finds the maximal sequence of equal elements in an array.
 */

using System;
class MaximalSequence
{
    static void Main()
    {
        int maxSeqDigit = 0;
        int counterMax = -1;
        int counter = 1;

        Console.WriteLine("Enter integer numbers, separated by a comma:");
        string seqStr = Console.ReadLine();
        int[] seqNum = Array.ConvertAll(seqStr.Split(','), int.Parse);
        int length = seqNum.Length;
        maxSeqDigit = seqNum[0];

        for (int i = 0; i < length - 1; i++)
        {
            if (seqNum[i] == seqNum[i + 1])
            {
                counter++;
                if (counter > counterMax)
                {
                    maxSeqDigit = seqNum[i];
                    counterMax = counter;
                }
            }
            else
            {
                counter = 1;
            }
        }

        for (int i = 0; i < counterMax - 1; i++)
        {
            Console.Write("{0}, ", maxSeqDigit);
        }
        Console.WriteLine(maxSeqDigit);
    }
}