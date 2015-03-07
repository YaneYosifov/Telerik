/*
 * Write a program to check if in a given expression 
 * the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d). 
 * Example of incorrect expression: )(a+b)).
 */

using System;
class CorrectBrackets
{
    static bool Brackets(string expression)
    {
        int counter = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                counter++;
            }
            else if (expression[i] == ')')
            {
                counter--;
            }
        }

        if (counter == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.Write("Enter an expression with brackets: ");
        string expression = Console.ReadLine();
        Console.WriteLine(Brackets(expression));
    }
}