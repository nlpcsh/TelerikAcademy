// Task 3 - Write a program that reads the radius r of a circle and prints 
//  its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write(" Enter the radius of a circle: ");
        float radii = float.Parse(Console.ReadLine());

        Console.WriteLine(" The area of the circle is: {0,21:0.00}", Math.PI * radii * radii);
        Console.WriteLine(" The perimeter of the circle is: {0,16:0.00}", 2 * Math.PI * radii );
    }
}

