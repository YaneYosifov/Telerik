namespace CohesionAndCoupling
{
    using System;

    public class Parallelepiped : Distance
    {
        private const string ArgumentOutOfRangeExceptionMessage = " should be positive number";
        private double width;
        private double height;
        private double depth;

        public Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width" + ArgumentOutOfRangeExceptionMessage);
                }

                this.width = value;
            }
        }

        public double Height 
        { 
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height" + ArgumentOutOfRangeExceptionMessage);
                }

                this.height = value;
            }
        }

        public double Depth 
        { 
            get
            {
                return this.depth;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Depth" + ArgumentOutOfRangeExceptionMessage);
                }

                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
