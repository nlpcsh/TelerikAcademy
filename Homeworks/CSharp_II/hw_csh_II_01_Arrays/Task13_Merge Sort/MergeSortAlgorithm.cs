// Task 13 - Write a program that sorts an array of integers using the 
//   Merge sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MergeSortAlgorithm
{
    static void Main()
    {
        Console.WriteLine(" Enter a line of integer numbers to form an array (1,2,4,6,8...): ");
        int[] intArray = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();

        int[] sortedArray = MergeSort(intArray);

        Console.WriteLine(" Merge-Sorted array: ");
        Console.WriteLine(string.Join(",", sortedArray));
    }

    //merges two arrays
    static int[] MergeArrays(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];

        int leftIncrease = 0;
        int rightIncrease = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
            {
                result[i] = left[leftIncrease];
                leftIncrease++;
            }
            else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (right[rightIncrease] <= left[leftIncrease])))
            {
                result[i] = right[rightIncrease];
                rightIncrease++;
            }
        }

        return result;
    }

    //recursevily merges two arrays
    static int[] MergeSort(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int middle = array.Length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[array.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = array[i];
        }

        for (int i = middle, j = 0; i < array.Length; i++, j++)
        {
            rightArray[j] = array[i];
        }

        leftArray = MergeSort(leftArray);
        rightArray = MergeSort(rightArray);

        return MergeArrays(leftArray, rightArray);
    }
}
