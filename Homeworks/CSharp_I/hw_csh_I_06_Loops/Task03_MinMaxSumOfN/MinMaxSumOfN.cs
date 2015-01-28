// Task 3 - Write a program that reads from the console a sequence of n integer 
//  numbers and returns the minimal, the maximal number, the sum and the average of
//  all numbers (displayed with 2 digits after the decimal point).
//  The input starts by the number n (alone in a line) followed by n lines, each 
//  holding an integer number.
//  The output is like in the examples below.

using System;

class MinMaxSumOfN
{
    static void Main()
    {
        Console.Write(" Enter integer for the numbers to process, please: ");

        int nbOfNumbers = int.Parse(Console.ReadLine());

        double[] nbArray = new Double[nbOfNumbers];

        // get all the numbers in one integer array
        for (int i = 0; i < nbOfNumbers; i++)
        {
            Console.Write(" Next number is: ");
            nbArray[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        double checkNb = nbArray[0];

        // check for MAX
        for (int i = 0; i < nbArray.Length; i++)
        {
            if (checkNb < nbArray[i])
            {
                checkNb = nbArray[i];
            }
        }
        Console.WriteLine(" MAX number is: " + checkNb);

        // check for MIN
        checkNb = nbArray[0];
        for (int i = 0; i < nbArray.Length; i++)
        {
            if (checkNb > nbArray[i])
            {
                checkNb = nbArray[i];
            }
        }
        Console.WriteLine(" MIN number is: " + checkNb);

        // sum and average of the numbers
        checkNb = 0;
        for (int i = 0; i < nbArray.Length; i++)
        {
            checkNb += nbArray[i];
        }
        Console.WriteLine(" Sum of all numbers is: " + checkNb);
        Console.WriteLine(" Averaged of all numbers is: {0:F2}", checkNb / nbOfNumbers);
    }
}