// Task 6 - Write a program that finds the biggest of five numbers by 
//   using only five if statements.

using System;

class BiggestOfFiveNb
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Enter forth number: ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("Enter fifth number: ");
        double e = double.Parse(Console.ReadLine());

        double maxNb = a;

        if (a < b)
        {
            maxNb = b;
        }
        if (maxNb < c)
        {
            maxNb = c;
        }
        if (maxNb < d)
        {
            maxNb = d;
        }
        if (maxNb < e)
        {
            maxNb = e;
        }

        Console.WriteLine(" The biggest number from {0}, {1}, {2}, {3} and {4} is {5}.", a, b, c, d, e, maxNb);
    }
}

