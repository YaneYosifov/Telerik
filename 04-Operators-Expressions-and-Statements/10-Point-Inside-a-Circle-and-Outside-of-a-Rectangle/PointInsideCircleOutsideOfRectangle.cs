using System;
class PointInsideCircleOutsideOfRectangle
{
    static void Main()
    {
        // * Write an expression that checks for given point (x, y) if it is 
        //   within the circle K({1, 1}, 1.5) and out 
        //   of the rectangle R(top=1, left=-1, width=6, height=2).

        while (true)
        {
            Console.Write("Enter X coordinate: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter Y coordiante: ");
            float y = float.Parse(Console.ReadLine());
            bool inCircle = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= Math.Pow(1.5f, 2);
            bool inRectangle = x >= -1 && x <= 5 && y >= -1 && y <= 1;

            if (inCircle && !inRectangle)
            {
                Console.WriteLine("yes\n");
            }
            else
            {
                Console.WriteLine("no\n");
            }
        }
    }
}