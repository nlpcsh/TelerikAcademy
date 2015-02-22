// Task 2 - Write a program that generates and prints to the console 
//    10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    private static Random randGen = new Random();

    static void Main()
    {
        Console.WriteLine(" Random number in range 100 - 200 is {0}", randGen.Next(100, 200));
    }
}

