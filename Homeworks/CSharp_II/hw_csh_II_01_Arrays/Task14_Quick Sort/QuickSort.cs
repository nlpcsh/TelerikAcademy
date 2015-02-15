// Task 14 - Write a program that sorts an array of integers using the 
//   Quick sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuickSort
{
    static void Main()
    {
        string[] array = { "Joro", "Evgeni",  "Ceco", "Pesho", "Gosho", "Boris", "Alex" };

        Console.WriteLine(" Unsorted array: ");
        Console.WriteLine(string.Join(",", array));

        // Apply Quicksort
        Quicksort(array, 0, array.Length - 1);

        Console.WriteLine(" Sorted array: ");
        Console.WriteLine(string.Join(",", array));
    }

    public static void Quicksort(IComparable[] elements, int left, int right)
    {
        int i = left, j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }
            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                // Swap
                IComparable temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }
        }
        if (left < j)
        {
            Quicksort(elements, left, j);
        }
        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}



