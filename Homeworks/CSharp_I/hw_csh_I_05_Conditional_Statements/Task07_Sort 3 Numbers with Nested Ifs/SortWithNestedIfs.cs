// Task 7 - Write a program that enters 3 real numbers and prints them sorted in
//   descending order.
//    Use nested if statements.

using System;

class SortWithNestedIfs
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a <= b)
        {
            if (b < c)
            {
                Console.WriteLine(" The numbers in descending order are: {0}, {1} and {2}", c, b, a);
            }
            else
            {
                if (a > c)
                {
                    Console.WriteLine(" The numbers in descending order are: {1}, {2} and {0}", c, b, a);
                }
                else
                {
                    Console.WriteLine(" The numbers in descending order are: {1}, {0} and {2}", c, b, a);
                }
            }
        }
        if (b < a)
        {
            if (a < c)
            {
                Console.WriteLine(" The numbers in descending order are: {0}, {2} and {1}", c, b, a);
            }
            else
            {
                if (b < c)
                {
                    Console.WriteLine(" The numbers in descending order are: {2}, {0} and {1}", c, b, a);
                }
                else
                {
                    Console.WriteLine(" The numbers in descending order are: {2}, {1} and {0}", c, b, a);
                }
            }
        }
    }
}

