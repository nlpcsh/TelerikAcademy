// Task 5 - Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine(" Enter a line of numbers for the sequence array (1,2,3,4,6,8...): ");
        int[] arrayInt = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();

        List<int> outputList = new List<int>();
        List<int> outputListMax = new List<int>();

        for (int i = 0; i < arrayInt.Length - 1; i++)
        {
            if (arrayInt[i + 1] == arrayInt[i] + 1)
            {
                outputList.Add(arrayInt[i]);

                if (outputList.Count >= outputListMax.Count)
                {
                    outputListMax.Clear();
                    for (int j = 0; j < outputList.Count; j++)
                    {
                        outputListMax.Add(outputList[j]);
                    }
                    outputListMax.Add(arrayInt[i + 1]);
                }
            }
            else
            {
                outputList.Clear();
            }
        }
        Console.Write(" Maximal increasing sequence of elements is: ");
        for (int i = 0; i < outputListMax.Count; i++)
        {
            Console.Write(" {0}", outputListMax[i]);
        }
        Console.WriteLine();
    }
}