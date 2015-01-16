// Task 4 - Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("To calculate rectangle's perimeter enter its:");
        Console.Write(" Height: ");
        float height = float.Parse(Console.ReadLine());
        Console.Write(" Width: ");
        float width = float.Parse(Console.ReadLine());

        Console.WriteLine(" Rectangle's Perimeter is: {0}", 2 * (height + width));
        Console.WriteLine(" Rectangle's Area is: {0}", height * width);
    }
}

