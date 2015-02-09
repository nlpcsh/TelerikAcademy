// Task 6 - Write a program that reads two integer numbers N and K 
//    and an array of N elements from the console.
//   Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.Write(" Enter the number of elements in the array N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write(" Enter the number of elements K: ");
        int K = int.Parse(Console.ReadLine());
        int sumMax = 0;
        int indexMaxSum = 0;

        Console.WriteLine(" Enter N integer numbers: ");
        int[] arrayInt = new int[N];

        for (int i = 0; i < N; i++)
        {
            arrayInt[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayInt.Length - K + 1; i++)
        {
            int sumK = 0;

            for (int j = i; j < i + K; j++)
            {
                sumK += arrayInt[j];
            }
            if (sumK >= sumMax)
            {
                sumMax = sumK;
                indexMaxSum = i;
            }
        }

        Console.Write(" Array of K ({0}) elements with max sum is:", K);

        for (int i = indexMaxSum; i < indexMaxSum + K; i++)
        {
            Console.Write(" {0}", arrayInt[i]);
        }
        Console.WriteLine();
    }
}

