// Task 10 - Write a program that finds in given array of integers a sequence 
//   of given sum S (if present).

using System;
using System.Linq;
using System.Collections.Generic;

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine(" Enter a line of numbers to form an array (1,2,4,6,8...): ");
        int[] intArray = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
        Console.Write(" Enter the sum (S): ");
        int S = int.Parse(Console.ReadLine());
        int currentSum = 0;
        int endIndex = 0;
        int startIndex = 0;
        int counterIndex = 0;
        int numbersOfSum = 0;
        bool isFinished = false;

        for (int i = 0; i < intArray.Length-1; i++)
        {
            currentSum = intArray[i];

            for (int j = i+1; j < intArray.Length; j++)
            {
                currentSum += intArray[j];

                counterIndex++;

                if (currentSum > S)
                {
                    break;
                }
                else if (currentSum == S)
                {
                    endIndex = j;
                    startIndex = i;
                    numbersOfSum = counterIndex;
                    isFinished = true;
                    break;
                }
            }
            if (isFinished)
            {
                break;
            }
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(" " + intArray[i]);
        }
        Console.WriteLine();
    }
}

