/* Problem 1. Shapes

Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
 */

namespace Task01_Shapes
{
    using System;

    class RunProgram
    {
        static void Main()
        {
            var arrayOfShapes = new Shape[] { new Triangle(2, 3), new Rectangle(2, 3), new Square(4) };

            foreach (var shape in arrayOfShapes)
            {
                Console.WriteLine(" Shape is: {0}", shape.GetType());
                Console.WriteLine(" Surface is: {0}", shape.CalculateSurface());
            }
        }
    }
}
