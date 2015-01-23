// Task 9 - Write a program that enters a number n and after that enters more n numbers
//   and calculates and prints their sum. 

using System;
using System.Linq;

class SumOfN
{
    static void Main()
    {
        Console.Write(" Enter the amount of number you whant to sum: ");
        int numbersToSum = int.Parse(Console.ReadLine());

        double[] arrayOfNb = new Double[numbersToSum];

        for (int i = 0; i < numbersToSum; i++)
        {
            Console.Write(" Next number is: ");
            arrayOfNb[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine(" Sum of entered numbers is: {0}", arrayOfNb.Sum());
    }
}

