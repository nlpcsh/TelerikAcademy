// Task 8 - In combinatorics, the Catalan numbers are calculated by the following 
//   formula: "catalan-formula"
//   Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write(" Enter an integer ( 0 <= n <= 100 ), please: ");
        int n = int.Parse(Console.ReadLine());

        while ((n < 0) || (n > 100))
        {
            Console.Write(" n is not in the range [0 <= n <= 100] ! : ");
            n = int.Parse(Console.ReadLine());
        }

        //double combinations = 0 ;
        BigInteger factN = 1;
        BigInteger fact2N = 1;
        BigInteger factNplus1 = 1;

        for (int i = 1; i <= 2*n; i++)
        {
            fact2N *= i;

            if (i <= n)
            {
                factN *= i;
            }
            if (i <= (n + 1))
            {
                factNplus1 *= i;
            }
        }
        Console.WriteLine(" Catalan number of {0} is equal to {1}", n, fact2N / (factNplus1 * factN));
    }
}

