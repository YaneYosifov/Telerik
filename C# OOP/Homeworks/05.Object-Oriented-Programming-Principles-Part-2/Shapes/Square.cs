namespace Shapes
{
    using System;
    public class Square : Shape
    {
        public Square(double width, double height)
            : base(width, height)
        {
        }

        public Square(double diameter)
            : base(diameter, diameter)
        {
        }

        public override double Height
        {
            get { return base.Height; }
            protected set
            {
                if (value != this.Width)
                {
                    throw new ArgumentException("Height must be the same as width");
                }
                base.Height = value;
            }
        }
        public override double CalculateSurface()
        {
            return Math.PI * (this.Width / 2) * (this.Height / 2);
        }
    }
}
