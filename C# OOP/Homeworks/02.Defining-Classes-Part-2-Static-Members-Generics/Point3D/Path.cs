/* Problem 4. Path
 * Create a class Path to hold a sequence of points in the 3D space.
 */

namespace Point3D
{
    using System.Collections.Generic;
    public class Path
    {
        private List<Point3D> pointsSequence;

        public List<Point3D> PointsSequence
        {
            get { return this.pointsSequence; }
            private set { this.pointsSequence = value; }
        }

        public Path()
        {
            this.PointsSequence = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.PointsSequence.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.pointsSequence.Remove(point);
        }
    }
}
