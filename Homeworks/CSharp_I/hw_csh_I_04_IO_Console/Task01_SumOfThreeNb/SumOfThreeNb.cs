// Task 1 - Write a program that reads 3 real numbers from the console 
//   and prints their sum.

using System;

class SumOfThreeNb
{
    static void Main()
    {
        Console.Write(" Enter the first number: ");
        float firstNb = float.Parse(Console.ReadLine());
        Console.Write(" Enter the second number: ");
        float secondNb = float.Parse(Console.ReadLine());
        Console.Write(" Enter the third number: ");
        float thirdNb = float.Parse(Console.ReadLine());

        Console.WriteLine(" Sum of the two numbers {0}, {1} and {2} is: {3}", firstNb, secondNb, thirdNb, firstNb+ secondNb);
    }

}

