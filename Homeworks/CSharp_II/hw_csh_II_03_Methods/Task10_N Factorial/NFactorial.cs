// Task 10 - Write a program to calculate n! for each n in the range [1..100].

using System  ;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        Console.Write(" Enter a number N to calculate N! : ");
        sbyte N = sbyte.Parse(Console.ReadLine());

        CalculateNFact(N);
    }
    static void CalculateNFact(sbyte N)
    {
        long fact = 1;

        if (N > 20)
        {
            var bigFact = new BigInteger(1);

            for (int i = 1; i <= N; i++)
            {
                bigFact *= i;
            }
            Console.WriteLine(bigFact);
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}

