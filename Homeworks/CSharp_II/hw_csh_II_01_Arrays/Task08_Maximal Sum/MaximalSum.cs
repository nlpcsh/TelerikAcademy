// Task 8 - Write a program that finds the sequence of maximal sum in given array.

using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine(" Enter a line of numbers for the array (1,2,4,6,8...): ");
        int[] arrayProcess = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
        int maxSum = 0;
        int currentSum = 0;
        int starIndex = 0;
        int indexMaxSum = 0;

        for (int i = 0; i < arrayProcess.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = 0;
                starIndex = i;
            }

            currentSum += arrayProcess[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                indexMaxSum = i;
            }
        }

        // Output
        Console.WriteLine(" Max sum is     : {0}", maxSum);
        Console.Write(" The sequence is:");
        for (int i = starIndex; i <= indexMaxSum; i++)
        {
            Console.Write(" " + arrayProcess[i]);
        }
        Console.WriteLine();
    }
}

