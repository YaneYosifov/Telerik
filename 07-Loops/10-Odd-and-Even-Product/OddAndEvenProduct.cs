using System;
class OddAndEvenProduct
{
    static void Main()
    {
        // * You are given n integers (given in a single line, separated by a space).
        // * Write a program that checks whether the product of the odd elements 
        //   is equal to the product of the even elements.
        // * Elements are counted from 1 to n, so the first element is odd, 
        //   the second is even, etc.

        Console.Write("Enter number of integers: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrNum = new int[n];
        Console.WriteLine("Enter {0} numbers, separated by a space:", n);
        string[] strNum = Console.ReadLine().Split();

        int odd = 1;
        int even = 1;

        for (int i = 0; i < n; i++)
        {
            arrNum[i] = int.Parse(strNum[i]);
        }

        for (int i = 0; i < arrNum.Length; i += 2)
        {
            odd *= arrNum[i];
        }

        for (int i = 1; i < arrNum.Length; i += 2)
        {
            even *= arrNum[i];
        }

        if (odd == even)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", odd);
        }
        else
	    {
            Console.WriteLine("no");
            Console.WriteLine("odd product = {0}", odd);
            Console.WriteLine("even product = {0}", even);
	    }
    }
}