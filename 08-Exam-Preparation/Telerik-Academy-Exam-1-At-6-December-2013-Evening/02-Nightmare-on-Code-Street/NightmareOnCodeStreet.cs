using System;
class NightmareOnCodeStreet
{
    static void Main()
    {
        char[] n = Console.ReadLine().ToCharArray();
        int[] nInt = Array.ConvertAll(n, c => (int)Char.GetNumericValue(c));
        int amount = 0;
        int sum = 0;

        for (int i = 0; i < nInt.Length; i++)
        {
            if (nInt[i] == -1)
            {
                continue;
            }
            else if (i % 2 != 0)
            {
                sum += nInt[i];
                amount++;
            }  
        }
        Console.WriteLine("{0} {1}", amount, sum);
    }
}