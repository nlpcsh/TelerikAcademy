// Task 3 - We are given a matrix of strings of size N x M. Sequences in 
//   the matrix we define as sets of several neighbour elements located on 
//   the same line, column or diagonal.
//  Write a program that finds the longest sequence of equal strings in 
//   the matrix.

using System;
using System.Collections.Generic;
using System.Linq;

class SequenceNMatrix
{
    static void Main()
    {
        Console.WriteLine(" Enter a matrix dimetions:");
        Console.Write(" Number of rows: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write(" Number of colums: ");
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine(" Please, enter 'N' lines of 'M' string elements: as,sa,das,we,mu");

        // test the initial input
        if (N < 1 || M < 1)
        {
            Console.WriteLine(" N or M are < 1 ");
            return;
        }

        string[,] matrix = new string[N, M];

        // Reading the Matrix from the console:
        for (int i = 0; i < N; i++)
        {
            string[] currentRow = Console.ReadLine().Split(',').ToArray();

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

        int maxElementCounter = 0;
        string maxOccurenceString = string.Empty;

        // set each one of the elements to be checked for a match 
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                string currentString = matrix[row, col];
                int counter = 0;

                // compare the current string element to all of the others
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (currentString == matrix[i, j])
                        {
                            counter++;
                        }
                        if (maxElementCounter < counter)
                        {
                            maxElementCounter = counter;
                            maxOccurenceString = currentString;
                        }
                    }

                }
            }
        }

        Console.WriteLine(" String with max occurence is: {0} - {1} times.", maxOccurenceString, maxElementCounter);
    }
}

