/*
 * Extend the previous program to support also 
 * subtraction and multiplication of polynomials.
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
            Console.Write("{0}x^{1}", Math.Abs(polynomial[i]), i);
            if (polynomial[i - 1] >= 0)
            {
                Console.Write(" + ");
            }
            else
            {
                Console.Write(" - ");
            }
        }
        Console.WriteLine("{0}", Math.Abs(polynomial[0]));
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
    static int[] PolynomialSubtract(int[] polynomial1, int[] polynomial2)
    {
        int[] result;
        if (polynomial1.Length > polynomial2.Length)
        {
            result = (int[])polynomial1.Clone();
            for (int i = 0; i < polynomial2.Length; i++)
            {
                result[i] -= polynomial2[i];
            }
        }
        else
        {
            result = (int[])polynomial2.Clone();
            for (int i = 0; i < polynomial1.Length; i++)
            {
                result[i] -= polynomial1[i];
            }
        }

        return result;
    }
    static int[] PolynomialMultiply(int[] polynomial1, int[] polynomial2)
    {
        int[] result = new int[polynomial1.Length + polynomial2.Length - 1];

        for (int i = 0; i < polynomial1.Length; i++)
        {
            for (int j = 0; j < polynomial2.Length; j++)
            {
                result[i + j] += (polynomial1[i] * polynomial2[j]);
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

        int[] result;

        Console.WriteLine("---------------------------");
        Console.Write("  ");
        PolynomialPrint(polynomial1);
        Console.WriteLine(" +");
        Console.Write("  ");
        PolynomialPrint(polynomial2);
        Console.WriteLine(" =");
        result = PolynomialAdd(polynomial1, polynomial2);
        Console.Write("  ");
        PolynomialPrint(result);

        Console.WriteLine("---------------------------");
        Console.Write("  ");
        PolynomialPrint(polynomial1);
        Console.WriteLine(" -");
        Console.Write("  ");
        PolynomialPrint(polynomial2);
        Console.WriteLine(" =");
        result = PolynomialSubtract(polynomial1, polynomial2);
        Console.Write("  ");
        PolynomialPrint(result);

        Console.WriteLine("---------------------------");
        Console.Write("  ");
        PolynomialPrint(polynomial1);
        Console.WriteLine(" *");
        Console.Write("  ");
        PolynomialPrint(polynomial2);
        Console.WriteLine(" =");
        result = PolynomialMultiply(polynomial1, polynomial2);
        Console.Write("  ");
        PolynomialPrint(result);
        Console.WriteLine("---------------------------");
    }
}