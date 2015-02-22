/* Task 4 
    Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
    Use System.Math.
*/

using System;
using System.IO;

class TriangleSurface
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\inputData.txt");
        Console.SetIn(reader);

        double a = 3, b = 4, c = 5, alpha = 45, h = 2;

        // Input values:
        Console.WriteLine(" Enter tringle info: ");
        Console.Write(" Side a = ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine(a);

        Console.Write(" Altitude h = ");
        h = double.Parse(Console.ReadLine());
        Console.WriteLine(h);

        Console.Write(" Side b = ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine(b);

        Console.Write(" Side c [ c < a + b ] = ");
        c = double.Parse(Console.ReadLine());
        Console.WriteLine(c);
        while (c > a + b)
        {
            Console.Write(" side c is > a + b Enter other value : ");
            c = double.Parse(Console.ReadLine());
        }

        Console.Write("angle alpha = ");
        alpha = double.Parse(Console.ReadLine());
        Console.WriteLine(alpha);

        Console.WriteLine();

        // Output...
        Console.WriteLine(" Area calculated by altitude is: {0,20:F2}", GetAreaWithAltitude(a, h));
        Console.WriteLine(" Area calculated by Heron formula is: {0,15:F2}", GetAreaWithHeron(a, b, c));
        Console.WriteLine(" Area calculated by thwo sides and angle is: {0,8:F2}", GetAreaWithAngle(a, b, alpha));
    }

    static double GetAreaWithAltitude(double a, double h)
    {
        double areaByAltitude = (a * h) / 2;
        return areaByAltitude;
    }

    static double GetAreaWithHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double areaHeron = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return areaHeron;
    }

    static double GetAreaWithAngle(double a, double b, double alpha)
    {
        double areaWithAngle = (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
        return areaWithAngle;
    }
}

