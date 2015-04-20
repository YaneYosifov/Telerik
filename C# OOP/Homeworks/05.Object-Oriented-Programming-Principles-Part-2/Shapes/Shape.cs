namespace Shapes
{
    using System;
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be equal or less or than 0");
                }
                this.width = value; 
            }
        }

        public virtual double Height
        {
            get { return this.height; }
            protected set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be equal or less than 0");
                }
                this.height = value; 
            }
        }
        
        public abstract double CalculateSurface();
    }
}
