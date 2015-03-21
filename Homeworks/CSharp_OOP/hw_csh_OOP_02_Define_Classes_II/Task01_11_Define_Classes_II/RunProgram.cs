/* Problem 1. Structure

 Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
 Implement the ToString() to enable printing a 3D point.

 * Problem 2. Static read-only field

 Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
 Add a static property to return the point O.

 * Problem 3. Static class

 Write a static class with a static method to calculate the distance between two points in the 3D space.

 * Problem 4. Path

 Create a class Path to hold a sequence of points in the 3D space.
 Create a static class PathStorage with static methods to save and load paths from a text file.
 Use a file format of your choice.

 * Problem 5. Generic class

 Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
 Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
 Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
 Check all input parameters to avoid accessing elements at invalid positions.

 * Problem 6. Auto-grow

 Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

 * Problem 7. Min and Max

 Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
 You may need to add a generic constraints for the type T.

 * Problem 8. Matrix

 Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

 * Problem 9. Matrix indexer

 Implement an indexer this[row, col] to access the inner matrix cells.

 * Problem 10. Matrix operations

 Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
 Throw an exception when the operation cannot be performed.
 Implement the true operator (check for non-zero elements).

 * Problem 11. Version attribute

 Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
Apply the version attribute to a sample class and display its version at runtime.
*/

namespace Education_3D
{
    using System;
    using System.Collections.Generic;


    class RunProgram
    {
        
        static void Main()
        {
            // Problem 1 - Structure
            var somePoint = new Point3D(1, 1, 2);
            Console.WriteLine(somePoint.ToString());

            var secondPoint = new Point3D(1, 1, 1);
            Console.WriteLine(secondPoint.ToString());

            // Problem 2 - Static read-only field
            Point3D.PrintInitialPoint();

            // Problem 3 - Static class
            var distance = DistanceIn3D.CalculateDistance(somePoint, secondPoint);
            Console.WriteLine("Distance is: {0}", distance);

            // Problem 4 - Path
            var pathOfPoints = new Path();
            pathOfPoints.AddPoint(somePoint);
            pathOfPoints.AddPoint(secondPoint);

            // create file with points of the paths
            PathStorage.WritePathToFile(pathOfPoints.ToList());

            // read points from file (lines counting from 1)
            var patshFromFile = PathStorage.ReadPathFromFile(1);
            // print points from file:
            //for (int i = 0; i < patshFromFile.Count; i++)
            //{
            //    Console.WriteLine(patshFromFile[i].ToString()); 
            //}

            // Problem 5 - Generic list
            var someList = new GenericList<int>();
            Console.WriteLine("Some Generic list<int> printings:");
            someList.Add(1);
            someList.Add(22);
            someList.Add(2);
            Console.WriteLine(someList.ToString());

            someList.Remove(0);
            Console.WriteLine(someList.ToString());

            someList.Incert(1, 44);
            Console.WriteLine(someList.ToString());

            someList.Clear();
            Console.WriteLine(someList.ToString());

            // Problem 6 - Auto-grow
            Console.WriteLine(" List length BEFORE adding any elements: {0} ", someList.Length);
            someList.Add(11);
            someList.Add(12);
            Console.WriteLine(" List length AFTER adding 2 elements: {0} ", someList.Length);
            someList.Add(13);
            someList.Add(33);
            someList.Add(44);
            Console.WriteLine(" List length AFTER adding 5 elements: {0} ", someList.Length);
            Console.WriteLine(someList.ToString());

            // Problem 7 - Min and Max
            Console.WriteLine("Max value is: {0}", someList.Max());
            Console.WriteLine("Min value is: {0}", someList.Min());

            // Problem 8, 9 - Matrix
            var matrix1 = new Matrix<int>(2,2);
            // put some values in the matrix

            Console.WriteLine(" Matrix 1: ");
            matrix1.PutSomeValues(matrix1, 2);
            matrix1.PrintMatrix();

            var matrix2 = new Matrix<int>(2, 2);
            // put some values in the matrix
            Console.WriteLine(" Matrix 2: ");
            matrix2.PutSomeValues(matrix2, 1);
            matrix2.PrintMatrix();

            // Problem 10 - Check operators over matrixes
            Console.WriteLine(" Summed matrix is: ");
            var sumMatrix = matrix1 + matrix2;
            sumMatrix.PrintMatrix();

            Console.WriteLine(" Minus matrix is: ");
            var minusMatrix = matrix1 - matrix2;
            minusMatrix.PrintMatrix();

            Console.WriteLine(" Mult matrix is: ");
            var multMatrix = matrix1 * matrix2;
            multMatrix.PrintMatrix();

            if (matrix1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            // Problem 11 - Version attribute
            Type type = typeof(Point3D);
            object[] attr = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }

    }
}
