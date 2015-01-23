// Task 10 - Write a program that reads a number n and prints on the console the first n 
//   members of the Fibonacci sequence (at a single line, separated by comma and space - ,):
//   0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;
using System.Linq;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write(" Enter a number up to Fibonacci sequence will be printed: ");
        int fibonacciToPrint = int.Parse(Console.ReadLine());

        int nb1 = 0, nb2 = 1, nextNb = 0 ;

        Console.Write(" {0}, {1}", nb1, nb2);

        for (int i = 0; i < fibonacciToPrint; i++)
        {
            nextNb = nb1 + nb2 ;
            Console.Write(", {0}", nextNb);
            nb1 = nb2;
            nb2 = nextNb;
        }

        Console.WriteLine();
    }
}

