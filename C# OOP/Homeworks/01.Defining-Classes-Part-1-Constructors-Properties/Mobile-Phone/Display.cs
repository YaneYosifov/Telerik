using System;

public class Display
{
    private double size;
    private int colors;

    public Display()
    {
    }

    public Display(double size, int colors)
    {
        this.Size = size;
        this.Colors = colors;
    }

    // Task 5
    public double Size
    {
        get { return this.size; }
        set
        {
            if (Double.IsNaN(value))
                throw new ArgumentException("Invalid display size!");
            this.size = value;
        }
    }

    public int Colors
    {
        get { return this.colors; }
        set
        {
            if (value < Int32.MinValue || value > Int32.MaxValue)
                throw new ArgumentException("Invalid colors value!");
            this.colors = value;
        }
    }
}