// Task 10 - Write an expression that checks for given point (x, y) 
//   if it is within the circle K({1, 1}, 1.5) and out of the rectangle
//   R(top=1, left=-1, width=6, height=2).

using System;

class CheckIfIncide
{
    static void Main()
    {
        Console.Write(" Enter X coordinate: ");
        float x = float.Parse(Console.ReadLine());

        Console.Write(" Enter Y coordinate: ");
        float y = float.Parse(Console.ReadLine());

        bool inRect = ((( x <= 5 ) && ( x >= -1 )) && (( y <= 1 ) && ( y >= -2 ))) ? true : false ;

        bool inCircle = (( (x - 1) * (x - 1) + (y - 1) * (y - 1) ) <= (1.5f * 1.5f) ) ? true : false ;

        string checkIfInside = ((inCircle == true) && (inRect == false)) ? " -> point is OUTSIDE the rectangle and INSIDE the circle!" : " -> Point is outside of the desired area!" ;

        Console.WriteLine("X = {0}, Y = {1}  {2}", x, y, checkIfInside);
    }
}

