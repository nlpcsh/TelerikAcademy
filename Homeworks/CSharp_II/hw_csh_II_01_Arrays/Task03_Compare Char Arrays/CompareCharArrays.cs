// Task 3 - Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        bool isEqual = false;
        Console.WriteLine(" Enter the first line of characters to compare (any text will do): ");
        char[] arrayOne = Console.ReadLine().Select(n => Convert.ToChar(n)).ToArray();
        Console.WriteLine(" Enter the second line of characters to compare (any text will do): ");
        char[] arrayTwo = Console.ReadLine().Select(n => Convert.ToChar(n)).ToArray();

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
