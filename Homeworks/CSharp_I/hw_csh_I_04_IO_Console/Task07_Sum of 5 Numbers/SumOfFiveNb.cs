// Task 7 - Write a program that enters 5 numbers (given in a single line, separated by
//   a space), calculates and prints their sum.

using System;
using System.Linq;

class SumOfFiveNb
{
    static void Main()
    {
        Console.WriteLine(" Enter the numbers one after another: nb1 nb2 nb3 nb4 nb5");
        string enteredNumbers = Console.ReadLine();

        string[] array = enteredNumbers.Split(' ');
        double[] nbArray = new Double[array.Length] ;

        for (int i = 0; i < array.Length; i++)
		{
            nbArray[i] = Convert.ToDouble(array[i]);
		}

        Console.WriteLine(" Sum of the numbers is: {0}", nbArray.Sum());
    }
}

