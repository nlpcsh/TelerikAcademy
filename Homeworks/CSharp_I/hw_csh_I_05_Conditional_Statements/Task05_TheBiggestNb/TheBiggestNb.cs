// Task 5 - Write a program that finds the biggest of three numbers.

using System;

class TheBiggestNb
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNb = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNb = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNb = double.Parse(Console.ReadLine());

        double maxNb = firstNb;

        if (firstNb < secondNb)
        {
            maxNb = secondNb;
        }
        if (maxNb < thirdNb )
        {
            maxNb = thirdNb;
        }
        Console.WriteLine(" The biggest Number is: {0}", maxNb);
    }
}

