// Task 13 - Write a program that safely compares floating-point numbers (double) 
//   with precision eps = 0.000001.

using System;

class ComparingFloats
{
    static void Main()
    {
        double firstNumber = 5.5000000002;
        double secondNumber = 5.50000001;

        double eps = 0.0000002;

        if (Math.Abs(firstNumber - secondNumber) <= eps)
        {
            Console.WriteLine(" First number ({0}) is equal to the socond number ({1}) with precision {2}", firstNumber, secondNumber, eps);
        }
    }
}

