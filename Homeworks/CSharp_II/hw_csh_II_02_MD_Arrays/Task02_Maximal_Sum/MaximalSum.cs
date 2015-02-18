// Task 2 - Write a program that reads a rectangular matrix of size N x M and
//   finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine(" Enter a matrix dimetions:");
        Console.Write(" Number of rows: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write(" Number of colums: ");
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine(" Please, enter 'N >= 3' lines of 'M >= 3' integer elements: 2, 4, 87, 22, 1");

        // test the initial input
        if (N < 3 || M < 3)
        {
            Console.WriteLine(" N or M are < 3 ");
            return;
        }

        int[,] matrix = new int[N, M];

        // Reading the Matrix from the console:
        for (int i = 0; i < N; i++)
        {
            int[] currentRow = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();

            if (currentRow.Length < M)
            {
                Console.WriteLine(" Number of colums does NOT correspond to initial value! ");
                return;
            }

            for (int j = 0; j < M; j++)
			{
                matrix[i, j] = currentRow[j];
			}
        }

        // finding the sum of all elements:

        // initial sum:
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                sum += matrix[i, j];
            }
        }

        //int currentSum = 0;
        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                                 matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                                 matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (currentSum > sum)
                {
                    sum = currentSum;
                }
            }
        }

        Console.WriteLine(" Maximal sum is: {0}", sum);
    }
}

