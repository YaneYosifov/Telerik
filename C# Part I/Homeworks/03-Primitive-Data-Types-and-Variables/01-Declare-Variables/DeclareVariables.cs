using System;
class DeclareVariables
{
    static void Main()
    {
        // * Declare five variables choosing for each of them the most appropriate of the types 
        //   byte, sbyte, short, ushort, int, uint, long, ulong 
        //   to represent the following values: 52130, -115, 4825932, 97, -10000.
        // * Choose a large enough type for each number to ensure it will fit in it. 
        //   Try to compile the code.

        byte a = 97;
        sbyte b = -115;
        ushort c = 52130;
        int d = 4825932;
        short e = -10000;

        Console.WriteLine("a = {0}\nb = {1}\nc = {2}\nd = {3}\ne = {4}", a, b, c, d, e);
    }
}