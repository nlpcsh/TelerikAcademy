// Task 1 - Write a program that fills and prints a matrix of size (n, n) in three different ways
/*
1 	5 	9 	13
2 	6 	10 	14
3 	7 	11 	15
4 	8 	12 	16

1 	8 	9 	16
2 	7 	10 	15
3 	6 	11 	14
4 	5 	12 	13

7 	11 	14 	16
4 	8 	12 	15
2 	5 	9 	13
1 	3 	6 	10
*/

using System;
using System.Collections.Generic;
using System.Linq;

class FillPrintMatrix
{
    static void Main()
    {
        Console.WriteLine(" Enter the size of a matrix N:");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];

        FillMatrix1(matrix, N);

        Console.WriteLine();

        FillMatrix2(matrix, N);

        Console.WriteLine();

        FillMatrix3(matrix, N);

    }

    public static void FillMatrix1(int[,] matrix, int N)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = 1 + col * N + row;
                Console.Write(" {0}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    public static void FillMatrix2(int[,] matrix, int N)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = 1 + col * N + row;
                    Console.Write(" {0}", matrix[row, col]);
                }
                else
                {
                    matrix[N - row - 1, col] = (col + 1) * N - row;
                    Console.Write(" {0}", matrix[N - row - 1, col]);
                }
            }
            Console.WriteLine();
        }
    }

    public static void FillMatrix3(int[,] matrix, int N)
    {
        bool isFilled = false;
        bool fillFirstPart = true;
        int counter = 0;
        int colMax = 0;
        int currentRow = matrix.GetLength(1) - 1;
        int colInitial = 0;

        while (!isFilled)
        {
            if (fillFirstPart)
            {
                // filling down left part of the matrix
                for (int col = colInitial, row = currentRow; col <= colMax; col++, row++)
                {
                    counter++;

                    matrix[row, col] = counter;

                }

                currentRow--;
                colMax++;

                if (currentRow < 0)
                {
                    fillFirstPart = false;
                    currentRow = 0;
                    colInitial = 1;
                }
            }

            // filling upper right part of the matrix
            else
            {
                for (int col = colInitial, row = 0; col <= matrix.GetLength(1) - 1; col++, row++)
                {
                    counter++;

                    matrix[row, col] = counter;

                }
                if (counter >= (matrix.GetLength(1) * matrix.GetLength(0)))
                {
                    isFilled = true;
                    break;
                }
                colInitial++;
            }
        }
        // Printing the Matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" {0}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

    }
}

