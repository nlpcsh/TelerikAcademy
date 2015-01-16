// Task 7 - Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write(" Enter X coordinate: ");
        float x = float.Parse(Console.ReadLine());

        Console.Write(" Enter Y coordinate: ");
        float y = float.Parse(Console.ReadLine());

        Console.WriteLine( (Math.Sqrt(x*x + y*y) <= 2 ) ? "Point is in the circle!" : " Point is NOT in the circle!");
    }
}

