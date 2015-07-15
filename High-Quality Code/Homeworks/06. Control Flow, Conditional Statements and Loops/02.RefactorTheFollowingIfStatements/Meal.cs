public class Meal
{
    public static void Main()
    {
        Potato potato;

        // ... 
        if (potato != null)
        {
            if (potato.HasBeenPeeled && !potato.IsRotten)
            {
                Cook(potato);
            }
        }

        bool inRangeX = MIN_X <= x && x <= MAX_X;
        bool inRangeY = MIN_Y <= y && y <= MAX_Y;
        if (shouldVisitCell && inRangeX && inRangeY)
        {
            VisitCell(x, y);
        }
    }
}