/*
 * Write a method that adds two polynomials.
 * Represent them as arrays of their coefficients.
 * Example: x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
 */

using System;
class AddingPolynomials
{
    static int[] Input()
    {
        Console.Write("Enter polynomial degree: ");
        int[] polynomial = new int[int.Parse(Console.ReadLine()) + 1];
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            Console.Write("x^{0}: ", i);
            polynomial[i] = int.Parse(Console.ReadLine());
        }

        return polynomial;
    }

    static void PolynomialPrint(int[] polynomial)
    {
        for (int i = polynomial.Length - 1; i > 0; i--)
        {
            Console.Write("{0}x^{1} + ", polynomial[i], i);
        }
        Console.WriteLine("{0}", polynomial[0]);
    }

    static int[] PolynomialAdd(int[] polynomial1, int[] polynomial2)
    {
        int[] result;
        if (polynomial1.Length > polynomial2.Length)
        {
            result = (int[])polynomial1.Clone();
            for (int i = 0; i < polynomial2.Length; i++)
            {
                result[i] += polynomial2[i];
            }
        }
        else
        {
            result = (int[])polynomial2.Clone();
            for (int i = 0; i < polynomial1.Length; i++)
            {
                result[i] += polynomial1[i];
            }
        }

        return result;
    }
    static void Main()
    {
        int[] polynomial1 = Input();
        Console.Write("Polynomial in normal form: ");
        PolynomialPrint(polynomial1);
        Console.WriteLine();

        int[] polynomial2 = Input();
        Console.Write("Polynomial in normal form: ");
        PolynomialPrint(polynomial2);
        Console.WriteLine();

        Console.Write("  ");
        PolynomialPrint(polynomial1);
        Console.WriteLine(" +");
        Console.Write("  ");
        PolynomialPrint(polynomial2);
        Console.WriteLine(" =");
        int[] result = PolynomialAdd(polynomial1, polynomial2);
        Console.Write("  ");
        PolynomialPrint(result);
        Console.WriteLine();
    }
}