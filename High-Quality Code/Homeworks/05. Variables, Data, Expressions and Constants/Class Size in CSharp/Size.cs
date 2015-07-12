namespace Size
{
    using System;

    public class Size
    {
        private double width, height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public static Size GetRotatedSize(Size size, double angle)
        {
            double sinOfAngle = Math.Sin(angle);
            double cosOfAngle = Math.Cos(angle);

            double sinAbs = Math.Abs(sinOfAngle);
            double cosAbs = Math.Abs(cosOfAngle);

            double newWidth = (cosAbs * size.Width) + (sinAbs * size.Height);
            double newHeight = (sinAbs * size.Width) + (cosAbs * size.Height);

            Size newSize = new Size(newWidth, newHeight);
            return newSize;
        }
    }
}