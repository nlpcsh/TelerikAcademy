
namespace Education_3D
{
    //using System;
    using System.Collections.Generic;
    //using System.Linq;
    //using System.Text;

    public class Path
    {
        private List<Point3D> paths;

        public Path()
        {
            this.paths = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.paths.Add(point);
        }

        public List<Point3D> ToList()
        {
            var path = new List<Point3D>();

            for (int i = 0; i < paths.Count; i++)
			{
                path.Add(paths[i]);
			}
            return path;

        }
    }
}
