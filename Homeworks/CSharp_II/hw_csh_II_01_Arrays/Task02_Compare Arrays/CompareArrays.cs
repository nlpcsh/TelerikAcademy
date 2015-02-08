// Task 2 - Write a program that reads two integer arrays from the console and
//   compares them element by element.

using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine(" Enter a line of numbers for the first array (1 2 4 6 8...): ");
        int[] arrayOne = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        Console.WriteLine(" Enter a line of numbers for the second array (11 22 41 65 8...): ");
        int[] arrayTwo = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();


    }
}
