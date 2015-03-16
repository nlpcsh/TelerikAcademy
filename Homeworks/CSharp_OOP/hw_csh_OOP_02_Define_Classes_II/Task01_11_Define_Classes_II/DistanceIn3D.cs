
namespace Education_3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    static class DistanceIn3D
    {
        static void CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double dX = Math.Abs(firstPoint.X - secondPoint.X);
            double dY = Math.Abs(firstPoint.Y - secondPoint.Y);
            double dZ = Math.Abs(firstPoint.Z - secondPoint.Z);

            double distance = Math.Sqrt( dZ * dZ + dX * dX + dY * dY );

            Console.WriteLine(" Distance is: {0}", distance);
        }
    }
}
