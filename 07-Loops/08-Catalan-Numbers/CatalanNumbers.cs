using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        // * In combinatorics, the Catalan numbers are calculated 
        //   by the following formula: catalan-formula (2n)! / (n+1)! * n!
        // * Write a program to calculate the nth Catalan number 
        //   by given n (0 ≤ n ≤ 100).

        Console.Write("Enter a number between 0 and 100: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFacturielN = 1;
        BigInteger nFacturiel2N = 1;
        BigInteger sumFacturiel = 1;
        BigInteger catalanNumbers = 1;
        int counter = 1;

        while (counter <= n)
        {
            nFacturielN *= counter;
            counter++;
        }

        counter = 1;
        while (counter <= (n + 1))
        {
            sumFacturiel *= counter;
            counter++;
        }

        counter = 1;
        while (counter <= (2 * n))
        {
            nFacturiel2N *= counter;
            counter++;
        }

        catalanNumbers = (nFacturiel2N / (nFacturielN * sumFacturiel));
        Console.WriteLine("(2n)! / (n + 1)! * n! = {0}", catalanNumbers);
    }
}