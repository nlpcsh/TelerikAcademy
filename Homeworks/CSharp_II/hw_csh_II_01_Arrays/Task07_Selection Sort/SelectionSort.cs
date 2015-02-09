// Task 7 -  Sorting an array means to arrange its elements in increasing order. 
//   Write a program to sort an array.
//   Use the Selection sort algorithm: Find the smallest element, move it at
//     the first position, find the smallest from the rest, move it at the 
//     second position, etc.

using System;

using System.Collections.Generic;

class SelectionSort
{
    static void Main()
    {
        Console.Write(" Enter the number of elements in the array N: ");
        int N = int.Parse(Console.ReadLine());
        int exchangeValue = 0;
        int indexMinValue = 0;

        Console.WriteLine(" Enter N integer numbers to sort: ");
        int[] arrayInt = new int[N];

        for (int i = 0; i < N; i++)
        {
            arrayInt[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayInt.Length - 1; i++)
        {
            indexMinValue = i;
            for (int j = i + 1; j < arrayInt.Length; j++)
            {
                if (arrayInt[indexMinValue] > arrayInt[j])
                {
                    indexMinValue = j;
                }
            }
            if (indexMinValue != i)
            {
                exchangeValue = arrayInt[i];
                arrayInt[i] = arrayInt[indexMinValue];
                arrayInt[indexMinValue] = exchangeValue;
            }
        }

        // Printed Output
        Console.WriteLine(" Sorted array is: ");
        for (int i = 0; i < arrayInt.Length; i++)
        {
            Console.Write(arrayInt[i] + " ");
        }
    }
}
