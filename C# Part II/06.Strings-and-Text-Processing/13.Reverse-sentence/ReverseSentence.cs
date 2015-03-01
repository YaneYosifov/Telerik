/*
 * Write a program that reverses the words in given sentence.
 */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class ReverseSentence
{
    static string SentenceReverse(string sentenceInput)
    {
        List<string> sentenceWords = new List<string>(Regex
            .Replace(sentenceInput, @"([.,?!:;]+)", "").Split());
        sentenceWords.Reverse();

        int countPunctuation = 0;
        for (int i = 0; i < sentenceInput.Length; i++)
        {
            if (sentenceInput[i] == '.' || sentenceInput[i] == ',' ||
                sentenceInput[i] == '?' || sentenceInput[i] == '!' ||
                sentenceInput[i] == ':' || sentenceInput[i] == ';')
            {
                int countSpace = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (sentenceInput[j] == ' ')
                    {
                        countSpace++;
                    }
                }
                sentenceWords
                    .Insert(countSpace + 1 + countPunctuation, sentenceInput[i]
                    .ToString());
                countPunctuation++;
            }
        }

        string sequenceResult = string.Join(" ", sentenceWords);
        sequenceResult = Regex.Replace(sequenceResult, @"(\s)([.,?!:;]+)", "$2");

        return sequenceResult;
    }
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentenceInput = Console.ReadLine();
        Console.WriteLine("Result: {0}", SentenceReverse(sentenceInput));
    }
}