
namespace Education_3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    //using System.Text;
    using System.IO;

    static class PathStorage
    {
        static string pathToFileWithPaths = "..\\..\\SavedPats.txt";

        public static void WritePathToFile(List<Point3D> path)
        {
            StreamWriter sw = new StreamWriter(pathToFileWithPaths);

            Console.WriteLine(" Points to be stored in file: ");
            for (int i = 0; i < path.Count; i++)
            {
                Console.Write("P({0},{1},{2}) ", path[i].x, path[i].y, path[i].z);
                sw.Write("{0} {1} {2} ", path[i].x, path[i].y, path[i].z);
            }
            Console.WriteLine();
            
            sw.Close();
        }

        public static List<Point3D> ReadPathFromFile(int lineIndex)
        {
            if (lineIndex <= 0)
            {
                throw new ArgumentException(" Index of a line to be read from file can't be 0 or negative! ");
            }
            StreamReader sr = new StreamReader(pathToFileWithPaths);

            string line = " " ;
            List<Point3D> paths = new List<Point3D>();

            int counter = 0;

            while (line != null)
            {
                counter++;
                line = sr.ReadLine();

                if (counter == lineIndex)
                {
                    Console.WriteLine(" Points to read from file: ");
                    double[] intNumbers = line
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();

                    paths = ConvertLineOfNbToList(intNumbers);

                    // Print points from file
                    for (int i = 0; i < paths.Count; i++)
                    {
                        Console.WriteLine(" x={0}, y={1}, z={2} ", paths[i].x, paths[i].y, paths[i].z);
                    }
                    
                    break;
                }
            }
            

            sr.Close();

            return paths;
        }

        private static List<Point3D> ConvertLineOfNbToList(double[] intNumbers)
        {
            List<Point3D> paths = new List<Point3D>();

            // check if all points have 3 coordinates
            if (intNumbers.Length % 3 == 0)
            {
                for (int i = 0, j=1, k=2; i <= intNumbers.Length - 2 ; i+=3, j+=3, k+=3)
                {
                    Point3D point3D = new Point3D(intNumbers[i], intNumbers[j], intNumbers[k]);

                    paths.Add(point3D);
                }
            }
            else
            {
                throw new ArgumentException(" Not all points have 3 coordinates!!! ");
            }

            return paths;
        }
    }
}
