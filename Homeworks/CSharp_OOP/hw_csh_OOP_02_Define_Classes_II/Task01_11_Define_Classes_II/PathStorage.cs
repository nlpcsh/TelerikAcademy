using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Education_3D
{
    class PathStorage
    {

        static void WritePathToFile(List<Point3D> path)
        {
            StreamWriter sw = new StreamWriter("..\\..\\SavedPats.txt");

            for (int i = 0; i < path.Count; i++)
            {
                Console.Write("P({0},{1},{2}) ", path[i].X, path[i].Y, path[i].Z);
                sw.Write("P({0},{1},{2}) ", path[i].X, path[i].Y, path[i].Z);
            }

            sw.Close();
        }


        //static List<Poind3D> ReadPathFromFile()
        //{

        //}
    }
}
