using System;
class CheckForAPlayCard
{
    static void Main()
    {
        // * Classical play cards use the following signs to designate 
        //   the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
        //   Write a program that enters a string and prints “yes” 
        //   if it is a valid card sign or “no” otherwise.

        Console.Write("play card: ");
        string playCard = Console.ReadLine();
        int number;
        bool letter;

        if (int.TryParse(playCard, out number) && number >= 2 && number <= 10)
        {
            Console.WriteLine("yes");
        }
        else if (letter = playCard.IndexOfAny("JQKA".ToCharArray()) != -1)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}