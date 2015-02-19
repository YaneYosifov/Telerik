/*
 * Write a method that asks the user for his name and prints “Hello, <name>”
 * Write a program to test this method.
 */

using System;
class SayHello
{
    static void PrintHello(string enteredName)
    {
        Console.WriteLine("Hello, {0}", enteredName);
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        PrintHello(name);
    }
}