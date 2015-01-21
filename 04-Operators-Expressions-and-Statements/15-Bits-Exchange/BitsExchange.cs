using System;
class BitsExchange
{
    static void Main()
    {
        // * Write a program that exchanges bits 3, 4 and 5 
        //   with bits 24, 25 and 26 of given 32-bit unsigned integer.

        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        uint mask = ((7 << 3) | (7 << 24));
        uint firstBitGroup = (n >> 3) & 7;
        uint secondBitGroup = (n >> 24) & 7;
        Console.WriteLine((n & (~mask)) | ((firstBitGroup << 24) | (secondBitGroup << 3)));
    }
}