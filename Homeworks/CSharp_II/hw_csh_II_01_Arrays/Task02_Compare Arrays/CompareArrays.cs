﻿// Task 2 - Write a program that reads two integer arrays from the console and
//   compares them element by element.

using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        bool isEqual = false;
        Console.WriteLine(" Enter a line of numbers for the first array (1 2 4 6 8...): ");
        int[] arrayOne = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        Console.WriteLine(" Enter a line of numbers for the second array (11 22 41 65 8...): ");
        int[] arrayTwo = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        if (arrayOne.Length == arrayTwo.Length)
        {
            Console.WriteLine(" The two arrays have the same size and are comparable!");
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    Console.WriteLine(" Elements with index {0} have the same value {1}", i, arrayOne[i]);
                    isEqual = true;
                }
            }
        }
        if (!isEqual)
        {
            Console.WriteLine(" No equal element are present! ");
        }

    }
}
