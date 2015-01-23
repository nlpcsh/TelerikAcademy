// Task 6 - Write a program that reads the coefficients a, b and c of a quadratic equation
//   ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write(" Enter the first coefficient 'a' : ");
        double firstCoef = double.Parse(Console.ReadLine());
        Console.Write(" Enter the second coefficient 'b' : ");
        double secondCoef = double.Parse(Console.ReadLine());
        Console.Write(" Enter the third coefficient 'c' : ");
        double thirdCoef = double.Parse(Console.ReadLine());

        double discriminant = secondCoef * secondCoef - 4 * firstCoef * thirdCoef;

        if (discriminant >= 0)
        {
            Console.WriteLine(" Roots of the equation are: x1 = {0}, x2 = {1}",
                (-secondCoef + Math.Sqrt(discriminant)) / (2 * firstCoef),
                (-secondCoef - Math.Sqrt(discriminant)) / (2 * firstCoef));
        }
        else
        {
            Console.WriteLine(" No real roots to print!");
        }
    }
}
