// Task 11 - Write a program that enters 3 integers n, min and max (min != max) and
//   prints n random numbers in the range [min...max].

using System;

class PrintRandomInRange
{
    static void Main()
    {
        Console.Write(" Enter MAX integer, please: ");
        int maxValue = int.Parse(Console.ReadLine());
        Console.Write(" Enter MIN integer, please: ");
        int minValue = int.Parse(Console.ReadLine());
        Console.Write(" Enter number of random integers to be generated, please: ");
        int nbRandom = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        for (int i = 0; i < nbRandom; i++)
        {
            Console.Write(" {0} ", rnd.Next(minValue, maxValue+1));
        }

        Console.WriteLine();
    }
}

