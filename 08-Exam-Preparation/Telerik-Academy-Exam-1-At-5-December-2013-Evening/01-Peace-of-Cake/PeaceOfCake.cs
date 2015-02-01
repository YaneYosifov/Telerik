using System;
class PeaceofCake
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());
        decimal ab = a / b;
        decimal cd = c / d;
        decimal bd = b * d;
        decimal nominator = (ab + cd) * bd;
        decimal completeCakes = nominator / bd;

        if (completeCakes >= 1)
        {
            Console.WriteLine("{0}", Math.Floor(completeCakes));
        }
        else
        {
            Console.WriteLine("{0:F22}", completeCakes);
        }

        Console.WriteLine("{0:F0}/{1:F0}", nominator, bd);
    }
}