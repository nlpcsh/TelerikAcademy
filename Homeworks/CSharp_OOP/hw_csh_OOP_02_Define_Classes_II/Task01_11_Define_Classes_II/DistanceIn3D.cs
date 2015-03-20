
namespace Education_3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    static class DistanceIn3D
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double dX = Math.Abs(firstPoint.x - secondPoint.x);
            double dY = Math.Abs(firstPoint.y - secondPoint.y);
            double dZ = Math.Abs(firstPoint.z - secondPoint.z);

            double distance = Math.Sqrt( dZ * dZ + dX * dX + dY * dY );

            return distance;

        }
    }
}
