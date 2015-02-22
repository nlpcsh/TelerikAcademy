// Task 1 - Write a program that reads a year from the console and checks 
//    whether it is a leap one.
//  Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write(" Enter an year to check if it is leap one: ");
        ushort year = ushort.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine(" Yes! The year {0} is leap.", year);
        }
        else
        {
            Console.WriteLine(" No! Sorry. The year {0} is NOT leap.", year);
        }
        
    }
}

