// Task 4 - Write a program, that reads from the console an array 
//  of N integers and an integer K, sorts the array and using 
//  the method Array.BinSearch() finds the largest number in the 
//  array which is ≤ K. 

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {

        Console.WriteLine(" Enter a line of numbers to form an array (10,2,4,6,7,2,1...): ");
        int[] arrayInt = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
        Console.Write("Enter Searched value (K): ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(arrayInt);
        Console.WriteLine();

        // Print the sorted Array
        for (int i = 0; i < arrayInt.Length; i++)
        {
            Console.Write("{0, 2} ", i);
        }
        Console.WriteLine(" :Indexes");

        for (int i = 0; i < arrayInt.Length; i++)
        {
            Console.Write("{0, 2} ", arrayInt[i]);
        }
        Console.WriteLine(" :Values\n");

        int index = Array.BinarySearch(arrayInt, k);
        if (index == -1)
        {
            // The searched value is lower that all of the elements so there is no lower number
            // You can test that by entering "1" for K
            Console.Write("No such number! \n(The searched value is lower that all of\n the elements so there is no lower number)\n");
        }
        else if (index < -1)
        {
            int realIndex = ~index - 1;
            Console.WriteLine("The biggest number < than {0} is {1} with index of {2}", k, arrayInt[realIndex], realIndex);
        }
        else if (index >= 0)
        {
            Console.WriteLine("Number {0} exists in the array and has index of {1}", arrayInt[index], index);
        }

    }
}

