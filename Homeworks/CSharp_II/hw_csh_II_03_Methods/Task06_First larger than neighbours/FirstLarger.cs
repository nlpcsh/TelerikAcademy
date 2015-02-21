// Task 6 - Write a method that returns the index of the first element
//    in array that is larger than its neighbours, or -1, if there’s no such element.
//   Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLarger
{
    static void Main()
    {
        Console.Write(" Enter int numbers to form an array (1 3 5...): ");
        int[] intNumbers = Console.ReadLine()
                                  .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

        int elementPosition = FindFIrstBiggerElement(intNumbers);

        if (elementPosition > -1)
        {
            Console.WriteLine(" The element {0} is bigger than its neighbours! ", intNumbers[elementPosition]);
        }
        else
        {
            Console.WriteLine(" No element in the array - bigger than its neghbours! ");
        }

    }
    static int FindFIrstBiggerElement(int[] intNumbers)
    {
        for (int i = 1; i < intNumbers.Length - 1; i++)
        {
            bool findIt = CheckNeighbours(i, intNumbers);

            if (findIt)
            {
                return i;
            }
        }

        return -1;
    }


    static bool CheckNeighbours(int elementPosition, int[] intNumbers)
    {

        if (intNumbers[elementPosition] > intNumbers[elementPosition + 1] && intNumbers[elementPosition] > intNumbers[elementPosition - 1])
        {
            return true;
        }

        return false;
    }
}

