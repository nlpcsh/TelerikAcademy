// Task 4 - Write a method that counts how many times given number appears 
//    in given array.
//  Write a test program to check if the method is workings correctly.

using System;
using System.Linq;


class AppearanceCounter
{
    static void Main()
    {
        Console.Write(" Enter int numbers to form an array (1 3 5...): ");
        int[] intNumbers = Console.ReadLine()
                                  .Split(new char[] { ' ', ',' , '.' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

        CounterOfAppearence(intNumbers);

    }

    static void CounterOfAppearence(int[] intNumbers)
    {
        int counter = 0;
        Console.Write( " Enter a number to check its appearene in the array: " );
        int currentNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < intNumbers.Length; i++)
        {

            if (currentNumber == intNumbers[i])
            {
                counter++;
            }

        }
        Console.WriteLine(" Number {0} appear {1} times.", currentNumber, counter);
 
    }
}

