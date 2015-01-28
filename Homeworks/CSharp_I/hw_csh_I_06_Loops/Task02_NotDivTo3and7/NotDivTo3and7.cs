// Task 2 - Write a program that enters from the console a positive integer n and
//   prints all the numbers from 1 to n not divisible by 3 and 7, on a single 
//   line, separated by a space.

using System;

class NotDivTo3and7
{
    static void Main()
    {
        Console.Write(" Enter an integer, please: ");
        int totalToPrint = int.Parse(Console.ReadLine());

        for (int i = 1; i <= totalToPrint; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}

