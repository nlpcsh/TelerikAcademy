// Task 9 - Write a method that return the maximal element in a portion of array 
//     of integers starting at given index.
//   Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingArray
{
    static void Main()
    {
        Console.Write(" Enter int numbers to form an array (1 3 5...): ");
        int[] intNumbers = Console.ReadLine()
                                  .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

        Console.Write(" Enter : ");
        string strNumber1 = Console.ReadLine();

    }
}

