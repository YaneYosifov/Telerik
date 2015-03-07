/*
 * Write a method that adds two positive integer numbers 
 * represented as arrays of digits (each array element arr[i] 
 * contains a digit; the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits.
 */

using System;
using System.Linq;
using System.Numerics;
using System.IO;
using System.Text;
class NumberAsArray
{
    static string ReadLine()
    {
        Stream inputStream = Console.OpenStandardInput(10005);
        byte[] bytes = new byte[10005];
        int outputLength = inputStream.Read(bytes, 0, 10005);
        char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
        return new string(chars);
    }
    static BigInteger[] Input()
    {
        string input = ReadLine();
        BigInteger[] x = Array.ConvertAll(input.ToString().ToArray(), p => (BigInteger)p - 48);
        Array.Reverse(x);
        return x;
    }
    static BigInteger[] BigNumber(BigInteger[] firstNum, BigInteger[] secondNum)
    {
        BigInteger[] result;
        int lowerLength;

        if (firstNum.Length > secondNum.Length)
        {
            result = new BigInteger[firstNum.Length + 1];
            lowerLength = secondNum.Length;
        }
        else
        {
            result = new BigInteger[secondNum.Length + 1];
            lowerLength = firstNum.Length;
        }

        for (int i = 0; i < result.Length - 1; i++)
        {
            if (i < lowerLength && result[i] + firstNum[i] + secondNum[i] < 10)
            {
                result[i] += (firstNum[i] + secondNum[i]);
            }
            else if (i < lowerLength)
            {
                result[i] += firstNum[i] + secondNum[i];
                result[i + 1] = result[i] / 10;
                result[i] %= 10;
            }
            else if (firstNum.Length > secondNum.Length)
            {
                result[i] += firstNum[i];
            }
            else
            {
                result[i] += secondNum[i];
            }
        }

        Array.Reverse(result);
        return result;
    }

    static void Main()
    {
        Console.SetBufferSize(80, 512);
        Console.Write("First number = ");
        BigInteger[] x1 = Input();

        Console.Write("Second number = ");
        BigInteger[] x2 = Input();

        BigInteger[] finalResult = BigNumber(x1, x2);

        Console.Write("First number + Second number = ");
        if (finalResult[0] != 0)
        {
            Console.Write(finalResult[0]);
        }
        for (int i = 1; i < finalResult.Length - 2; i++)
        {
            Console.Write(finalResult[i]);
        }
        Console.WriteLine();
    }
}