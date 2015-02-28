/* Task 5 
    Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.
*/


using System;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("..//..//matrix.txt");
        int matrixSize = int.Parse(lines[0]);
        int[,] matrix = new int[matrixSize, matrixSize];

        for (int i = 1; i < lines.Length; i++)
        {
            string[] currentLine = lines[i].Split();
            for (int j = 0; j < currentLine.Length; j++)
            {
                matrix[i - 1, j] = int.Parse(currentLine[j]);
            }
        }

        File.WriteAllText("..//..//MaxSubMatrixSum.txt", "The sum of the maximum Submatrix is: " + FindMaxSubmatrixSum(matrix).ToString());
        Console.WriteLine("Task Complete!");
    }

    static int FindMaxSubmatrixSum(int[,] matrix)
    {
        int currentSum = 0;
        int bestSum = int.MinValue;

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                currentSum = matrix[i, j] + matrix[i, j + 1] +
                             matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                }
            }
        }
        return bestSum;
    }
}

