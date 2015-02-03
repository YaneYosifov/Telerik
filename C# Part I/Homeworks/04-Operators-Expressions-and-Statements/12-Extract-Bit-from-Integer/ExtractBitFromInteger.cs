using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        // * Write an expression that extracts from given 
        //   integer n the value of given bit at index p.

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int bit = (n & mask) >> p;
        Console.WriteLine(bit);
    }
}