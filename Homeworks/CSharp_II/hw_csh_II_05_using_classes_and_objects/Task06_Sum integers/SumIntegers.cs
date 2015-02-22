// Task 6 - You are given a sequence of positive integer values written 
//     into a string, separated by spaces.
//   Write a function that reads these values from given string and 
//     calculates their sum.

using System;
using System.Linq;
using System.IO;

class SumIntegers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\inputData.txt");
        Console.SetIn(reader);

        int[] intArray = ReadInputValues();

        Console.WriteLine("Initial array is: {0}",string.Join(",", intArray));

        int sum = SumArrayOfInt(intArray);

        Console.WriteLine(" Sum of all elements in the array is: {0}", sum);
    }

    static int[] ReadInputValues()
    {
        int[] intArray = Console.ReadLine()
                          .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
        return intArray;
    }

    static int SumArrayOfInt(int[] intArray)
    {
        int sum = 0;
        for (int i = 0; i < intArray.Length; i++)
        {
            sum += intArray[i];
        }

        return sum;
    }
}

