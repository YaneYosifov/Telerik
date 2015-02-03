using System;
class PrintADeckOf52Cards
{
    static void Main()
    {
        // * Write a program that generates and prints all possible cards 
        //   from a standard deck of 52 cards (without the jokers). 
        //   The cards should be printed using the classical notation 
        //   (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
        //   - The card faces should start from 2 to A.
        //   - Print each card face in its four possible suits: 
        //     clubs, diamonds, hearts and spades. 
        //     Use 2 nested for-loops and a switch-case statement.

        for (int i = 2; i <= 10; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(i);
                switch (j)
                {
                    case 0:
                        Console.Write(" of spades, ");
                        break;
                    case 1:
                        Console.Write(" of clubs, ");
                        break;
                    case 2:
                        Console.Write(" of hearts, ");
                        break;
                    case 3:
                        Console.WriteLine(" of diamonds");
                        break;
                    default:
                        break;
                }
            }
        }

        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
        Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
        Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
    }
}