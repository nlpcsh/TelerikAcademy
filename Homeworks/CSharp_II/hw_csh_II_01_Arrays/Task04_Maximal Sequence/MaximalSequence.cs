// Task 4 - Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        int counter = 0;
        Console.WriteLine(" Enter a line of numbers to search the maximal sequence of equal elements in it (1,2,4,2,2,2,1...): ");
        int[] arrayInt = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();

        int maxSequence = 1;
        int elementOfMaxSequence = arrayInt[0];

        for (int i = 0; i < arrayInt.Length - 1; i++)
        {
            counter = 1;

            for (int j = i+1; j < arrayInt.Length; j++)
            {
                if (arrayInt[i] == arrayInt[j])
                {
                    counter++;
                }
                else
                {
                    // optimizing the first "for" cycle
                    i = j - 1;
                    break;
                }
            }
            if (counter > maxSequence)
            {
                maxSequence = counter;
                elementOfMaxSequence = arrayInt[i];
            }
        }
        Console.WriteLine(" Maximal sequence of element {0} is {1} times", elementOfMaxSequence, maxSequence);
    }
}