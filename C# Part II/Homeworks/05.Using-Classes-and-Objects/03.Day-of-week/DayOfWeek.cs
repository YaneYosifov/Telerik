﻿/*
 * Write a program that prints to the console which day of the week is today.
 * Use System.DateTime.
 */

using System;
class DayOfWeek
{
    static void Main()
    {
        string today = DateTime.Now.DayOfWeek.ToString();
        Console.WriteLine("Today is {0}", today);
    }
}