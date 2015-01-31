// Task 6 - Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//   Use only one loop.

using System;
using System.Numerics;

class CalculateNFactOverKFact
{
    static void Main()
    {
        Console.Write(" Enter first  integer ( 1 < n < 100 ), please: ");
        int n = int.Parse(Console.ReadLine());

        while ((n <= 1) || (n >= 100))
        {
            Console.Write(" n is not in the range [1 < n < 100] ! : ");
            n = int.Parse(Console.ReadLine());
        }

        Console.Write(" Enter second integer (1 < k < 100), please: ");
        int k = int.Parse(Console.ReadLine());

        while ((k <= 1) || (k >= 100))
        {
            Console.Write(" k is not in the range [1 < k < 100] ! : ");
            k = int.Parse(Console.ReadLine());
        }

        int maxVal = n;
        BigInteger factN = 1;
        BigInteger factK = 1;

        // find bigger number
        if (maxVal < k)
        {
            maxVal = k;
        }

        for (int i = 1; i <= maxVal; i++)
        {
            if (i <= n)
            {
                factN *= i;
            }
            if (i <= k)
            {
                factK *= i;
            }
        }

        Console.WriteLine(" n!/k! = {0}", factN / factK);
    }
}

