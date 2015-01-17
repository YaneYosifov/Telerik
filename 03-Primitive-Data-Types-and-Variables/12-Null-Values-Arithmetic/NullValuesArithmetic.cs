using System;
class NullValuesArithmetic
{
    static void Main()
    {
        // * Create a program that assigns null values to an integer and to a double variable.
        // * Try to print these variables at the console.
        // * Try to add some number or the null literal to these variables and print the result.

        int? intNull = null;
        double? doubleNull = null;
        Console.WriteLine(intNull + "\n" + doubleNull);

        intNull = 24;
        doubleNull = 7;
        Console.WriteLine(intNull + "\n" + doubleNull);
    }
}