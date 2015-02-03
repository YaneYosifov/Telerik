using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.ASCII;
        for (byte i = 32; i < 128; i++)
        {
            Console.Write("{0}\n", (char)i);
        }
    }
}