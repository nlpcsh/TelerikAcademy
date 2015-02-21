// Task 9 - Write a method that return the maximal element in a portion of array 
//     of integers starting at given index.
//   Using it write another method that sorts an array in ascending / descending order.

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingArray
{
    static void Main()
    {
        
        StreamReader reader = new StreamReader("..\\..\\inputData.txt");
        Console.SetIn(reader);

        Console.WriteLine(" Enter int numbers to form an array (1 3 5...): ");
        int[] intNumbers = Console.ReadLine()
                                  .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

        // Print the initial array:
        Console.WriteLine(string.Join(",", intNumbers));

        Console.WriteLine(" Enter an index to search the array from it: ");
        int strIndex = int.Parse(Console.ReadLine());

        // Print the input index
        Console.WriteLine(strIndex);

        Console.WriteLine(" Max element is: {0}", SearchForMaxFromIndex(intNumbers, strIndex));

        intNumbers = SortTheArary(intNumbers);

        Console.WriteLine(" Sorted array is: ");
        Console.WriteLine(string.Join(",", intNumbers));

    }

    static int SearchForMaxFromIndex(int[] intArray, int index)
    {
        int maxElement = intArray[index];

        if (index < 0 || index > intArray.Length-1)
        {
            Console.WriteLine("Index is out of the array range! ");

            Environment.Exit(0);
            
        }

        for (int i = index; i < intArray.Length; i++)
        {
            if (maxElement < intArray[i])
            {
                maxElement = intArray[i];
            }
        }

        return maxElement;
    }

    static int[] SortTheArary(int[] arrayInt)
    {

        for (int i = 0; i < arrayInt.Length; i++)
        {
            int maxValue = SearchForMaxFromIndex(arrayInt, i);
            int indexMaxValue = Array.LastIndexOf(arrayInt, maxValue);

            if (indexMaxValue != i)
            {
                int exchangeValue = arrayInt[i];
                arrayInt[i] = arrayInt[indexMaxValue];
                arrayInt[indexMaxValue] = exchangeValue;
            }
        }

        Array.Reverse(arrayInt);

        return arrayInt;
    }
}

