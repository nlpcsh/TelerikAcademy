// Task 3 - Write a Boolean expression that checks for given integer if it can be 
// divided (without remainder) by 7 and 5 at the same time.

using System;

class Divide_by_7_and_5
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if can be devided by 5 or 7:");
        int toCheck = int.Parse(Console.ReadLine());

        Console.WriteLine((toCheck % (5 * 7)) == 0 ? "The Number CAN be devided by 7 and 5 at the same time" : "The Number can NOT be devided by 7 and 5");
    }
}

