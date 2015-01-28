// Task 1 - Write a program that enters from the console a positive 
//   integer n and prints all the numbers from 1 to n, on a single line, 
//   separated by a space.

using System;

class PrintToN
{
    static void Main()
    {
        Console.Write(" Enter an integer, please: ");
        int totalToPrint = int.Parse(Console.ReadLine());

        for (int i = 1; i <= totalToPrint; i++)
        {
            Console.WriteLine(i);
        }
    }
}

