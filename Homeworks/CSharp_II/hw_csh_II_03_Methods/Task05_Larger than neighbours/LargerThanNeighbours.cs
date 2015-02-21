// Task 5 - Write a method that checks if the element at given position in given 
//   array of integers is larger than its two neighbours (when such exist).
 
using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write(" Enter int numbers to form an array (1 3 5...): ");
        int[] intNumbers = Console.ReadLine()
                                  .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();
        
        Console.Write(" Give a position of an element to chef against its neighbours: ");
        int elementPosition = int.Parse(Console.ReadLine());

        CheckNeighbours(elementPosition, intNumbers);

    }

    static void CheckNeighbours(int elementPosition, int[] intNumbers)
    {
        if (elementPosition >= intNumbers.Length || elementPosition < 0)
        {
            Console.WriteLine(" No such element in the array! ");
            return;
        }
        else if (elementPosition == 0)
        {
            if (intNumbers[elementPosition] > intNumbers[1])
            {
                Console.WriteLine(" The first element is bigger than the second!");
            }
            else
            {
                Console.WriteLine(" The first element is NOT bigger than the second!");
            }
        }
        else if (elementPosition == intNumbers.Length - 1)
        {
            if (intNumbers[elementPosition] > intNumbers[intNumbers.Length - 2])
            {
                Console.WriteLine(" The last element is bigger than the previous one!");
            }
            else
            {
                Console.WriteLine(" The last element is NOT bigger than the previous one!");
            }
        }
        else
        {
            if (intNumbers[elementPosition] > intNumbers[elementPosition+1] && intNumbers[elementPosition] > intNumbers[elementPosition-1])
            {
                Console.WriteLine(" The element is bigger than its neighbours! ");
            }
            else
            {
                Console.WriteLine(" The element is NOT bigger than its neighbours!  ");
            }
        }
    }

}

