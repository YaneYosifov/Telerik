namespace LargerThanNeighbours
{
    using System;
    public class NumbersCollection
    {
        public NumbersCollection(int[] sequence, int toCheck)
        {
            if (toCheck < 0 || toCheck > sequence.Length - 1)
            {
                Console.WriteLine("invalid index");
                return;
            }

            Console.Write("The element at index {0} (number {1}) is ", toCheck, sequence[toCheck]);
            if (toCheck != 0 && toCheck != sequence.Length - 1 &&
                sequence[toCheck] > sequence[toCheck - 1] &&
                sequence[toCheck] > sequence[toCheck + 1])
            {
                Console.WriteLine("larger than its two neighbours");
            }
            else if (toCheck != 0 && sequence[toCheck] > sequence[toCheck - 1])
            {
                Console.WriteLine("larger than its left neighbour");
            }
            else if (toCheck != sequence.Length - 1 && sequence[toCheck] > sequence[toCheck + 1])
            {
                Console.WriteLine("larger than its right neighbour");
            }
            else
            {
                Console.WriteLine("not larger than its two neighbours");
            }
        }
    }
}