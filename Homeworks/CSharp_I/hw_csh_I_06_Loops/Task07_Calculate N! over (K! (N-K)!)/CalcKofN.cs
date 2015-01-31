// Task 7 - In combinatorics, the number of ways to choose k different members out of a group
//   of n different elements (also known as the number of combinations) is calculated by the 
//   following formula: formula For example, there are 2598960 ways to withdraw 5 cards out 
//   of a standard deck of 52 cards.
//   Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and 
//    k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

class CalculateKofN
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

        Console.Write(" Enter second integer (1 < k < n), please: ");
        int k = int.Parse(Console.ReadLine());

        while ((k <= 1) || (k >= n))
        {
            Console.Write(" k is not in the range [1 < k < n] ! : ");
            k = int.Parse(Console.ReadLine());
        }

        //double combinations = 0 ;
        BigInteger factN = 1;
        BigInteger factK = 1;
        BigInteger factNminusK = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;

            if (i <= k)
            {
                factK *= i;
            }
            if (i <= (n-k))
            {
                factNminusK *= i;
            }
        }

        Console.WriteLine(" {0} numbers out of {1} is {2}", k, n, factN / (factK * factNminusK));
    }
}

