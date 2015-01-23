// Task 9 - Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write(" Enter side 'a' of the trapezoid: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write(" Enter side 'b' of the trapezoid: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write(" Enter height 'h' of the trapezoid: ");
        float h = float.Parse(Console.ReadLine());

        Console.WriteLine(" Area of the trapezoid is: {0}", (a + b) * h / 2 );
    }
}

