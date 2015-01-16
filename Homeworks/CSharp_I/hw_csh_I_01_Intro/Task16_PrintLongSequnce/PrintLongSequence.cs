// Task 16 - Write a program that prints the first 1000 members of the sequence: 
//    2, -3, 4, -5, 6, -7, …

using System;

class Program
{
    static void Main()
    {
        int k = -1;

        for (int i = 2; i < 1002; i++)
        {
            k = k * (-1);
            Console.Write(i * k);
            Console.Write(", ");
        }
    }
}