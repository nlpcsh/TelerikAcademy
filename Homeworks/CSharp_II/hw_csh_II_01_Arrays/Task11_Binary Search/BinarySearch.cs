// Task 11 - Write a program that finds the index of given element in a sorted 
//   array of integers by using the Binary search algorithm.

using System;
using System.Linq;
using System.Collections.Generic;

class BinarySearch
{
    static void Main()
    {
        // Input array...
        Console.WriteLine(" Enter a line of integer numbers to form an array (1,2,4,6,8...): ");
        int[] intArray = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();

        Array.Sort(intArray);

        Console.WriteLine(" Sorted Array is: ");
        Console.WriteLine(string.Join(", ", intArray));

        Console.Write(" Enter an element of the array to find its index: ");
        int element = int.Parse(Console.ReadLine());

        // check if element exist in the array
        bool ifElementExist = false;
        foreach (var item in intArray)
        {
            if (item == element)
            {
                ifElementExist = true;
                break;
            }
        }

        if (!ifElementExist)
        {
            Console.WriteLine(" The element does not present in the array!");
            return;
        }

        // Binary search:
        int middleIndex = intArray.Length / 2;

        while (ifElementExist)
        {
            if (element > intArray[middleIndex])
            {
                middleIndex += (middleIndex / 2 + (middleIndex % 2));
            }
            else if (element < intArray[middleIndex])
            {
                middleIndex -= (middleIndex / 2 + (middleIndex % 2));
            }
            else
            {
                ifElementExist = false;
                break;
            }
        }

        Console.WriteLine(" Intex of the element {0} is: {1}", element, middleIndex);

    }
}

