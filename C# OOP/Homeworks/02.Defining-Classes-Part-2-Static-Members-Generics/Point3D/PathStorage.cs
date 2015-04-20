/* Problem 4. Path
 * Create a static class PathStorage with static methods to save and load paths from a text file.
 * Use a file format of your choice.
 */

namespace Point3D
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.IO;
    using System.Linq;
    class PathStorage
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var pointsSequence = new Path();

            Point3D firstPoint3D = new Point3D(1.2, 2.4, 3.7);
            pointsSequence.AddPoint(firstPoint3D);
            Console.WriteLine("Point({0})", firstPoint3D);

            Point3D secondPoint3D = Point3D.StartPoint;
            pointsSequence.AddPoint(secondPoint3D);
            Console.WriteLine("Point({0})", secondPoint3D);

            Console.WriteLine("Distance between the points: {0:F2}", Distance.CalcDistance(firstPoint3D, secondPoint3D));

            pointsSequence.RemovePoint(firstPoint3D);
            pointsSequence.RemovePoint(secondPoint3D);

            Path path3D = new Path();

            string[] points = File.ReadAllText(@"..\..\input.txt").Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            File.WriteAllText(@"..\..\output.txt", string.Empty);

            Console.WriteLine("\nPoints loaded from input.txt");
            int index = 0;
            while (index < points.Length)
            {
                double[] coordinates = points[index].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(double.Parse)
                                                .ToArray();
                path3D.AddPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                Console.WriteLine("{0}", path3D.PointsSequence[index]);
                File.AppendAllText(@"..\..\output.txt", points[index] + Environment.NewLine);
                index++;
            }

            Console.WriteLine("Points saved to output.txt\n");
        }
    }
}
