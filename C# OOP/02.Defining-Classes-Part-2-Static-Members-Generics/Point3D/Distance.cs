/* Problem 3. Static class
 * Write a static class with a static method to calculate the distance between two points in the 3D space.
 */

namespace Point3D
{
    using System;
    public static class Distance
    {
        public static double CalcDistance(Point3D point1, Point3D point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2) + Math.Pow(point2.Z - point1.Z, 2));
        }
    }
}