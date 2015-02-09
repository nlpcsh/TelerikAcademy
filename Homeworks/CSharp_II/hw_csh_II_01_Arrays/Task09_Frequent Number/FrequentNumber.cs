// Task 9 - Write a program that finds the most frequent number in an array.

using System;
using System.Linq;
using System.Collections.Generic;

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine(" Enter a line of numbers for the array (1,2,4,6,8...): ");
        int[] arrayProcess = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
        int maxOccurence = 0;
        int index = 0;
        int occurenceCounter = 1;

        Array.Sort(arrayProcess);

        for (int i = 0; i < arrayProcess.Length; i++)
        {
            Console.WriteLine(arrayProcess[i]);
        }

        for (int i = 0; i < arrayProcess.Length - 1; i++)
        {
            if (arrayProcess[i] == arrayProcess[i + 1])
            {
                occurenceCounter++;
                if (maxOccurence < occurenceCounter)
                {
                    maxOccurence = occurenceCounter;
                    index = i;
                }
            }
            else
            {
                occurenceCounter = 1;
            }
        }

        Console.WriteLine(" Number {0} ( {1} times )", arrayProcess[index], maxOccurence);
    }
}
