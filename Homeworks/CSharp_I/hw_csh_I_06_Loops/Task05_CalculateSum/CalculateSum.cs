// Task 5 - Write a program that, for a given two integer numbers n and x, calculates the 
//   sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//   Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Numerics;

class CalculateSum
{
    static void Main()
    {
        Console.Write(" Enter first  integer ( n>0 ), please: ");
        int firstInt = int.Parse(Console.ReadLine());

        while (firstInt < 0)
        {
            Console.Write(" n is less than 0... Please enter positive n! :");
            firstInt = int.Parse(Console.ReadLine());
        }
        
        Console.Write(" Enter second integer (x), please: ");
        int secondInt = int.Parse(Console.ReadLine());

        double sum = 1 ;
        long fact = 1;

        for (int i = 1; i <= firstInt; i++)
        {
            fact *= i;
            sum += fact / Math.Pow(secondInt, i);
        }
        Console.WriteLine(" 1 + 1!/x + 2!/x2 + . . . + n!/x^n = {0:F5}", sum);
    }
}

