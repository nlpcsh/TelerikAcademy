
namespace Education_3D
{
    using System;
    //using System.Collections.Generic;
    //using System.Linq;
    //using System.Text;

    [VersionAttribute("version 1.11")]
    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public double x;
        public double y;
        public double z;

        public static Point3D Point0
        {
            get { return pointO; }
        }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format("Point({0},{1},{2})", this.x, this.y, this.z);
        }

        public static void PrintInitialPoint()
        {
            Console.WriteLine("Point0 ({0},{1},{2})", pointO.x, pointO.y, pointO.z);
        }
    }
}
