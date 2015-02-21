// Task 2 - Write a method GetMax() with two parameters that returns the larger 
//    of two integers.
//  Write a program that reads 3 integers from the console and prints the largest
//    of them using the method GetMax().

using System;
using System.Linq;

class TheLargestNumber
{
    static void Main()
    {
        Console.Write(" Enter 3 int numbers to find the biggest (1 3 5): ");
        int[] intNumbers = Console.ReadLine()
                                  .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

        int greater1 = GetMax(intNumbers[0], intNumbers[1]);
        int greater2 = GetMax(intNumbers[2], intNumbers[1]);

        Console.WriteLine(" The largest number is: {0}", GetMax(greater1,greater2));

    }

    static int GetMax(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}

