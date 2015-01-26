// Task 4 - Write a program that shows the sign (+, - or 0) of the product of three real
//   numbers, without calculating it.
//     Use a sequence of if operators.

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNb = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNb = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNb = double.Parse(Console.ReadLine());

        if ((firstNb == 0) || (secondNb == 0) || (thirdNb == 0))
        {
            Console.WriteLine(" 0 ");
        }

        else if (firstNb < 0)
        {
            if (secondNb < 0)
            {
                if (thirdNb < 0)
                {
                    Console.WriteLine(" - ");
                }
                else if (thirdNb > 0)
                {
                    Console.WriteLine(" + ");
                }
            }
            else if (secondNb > 0) 
            {
                if (thirdNb < 0)
                {
                    Console.WriteLine(" + ");
                }
                else if (thirdNb > 0)
                {
                    Console.WriteLine(" - ");
                }
            }
        }

        else if (firstNb > 0)
        {
            if (secondNb < 0)
            {
                if (thirdNb < 0)
                {
                    Console.WriteLine(" + ");
                }
                else if (thirdNb > 0)
                {
                    Console.WriteLine(" - ");
                }
            }
            else if (secondNb > 0) 
            {
                if (thirdNb < 0)
                {
                    Console.WriteLine(" - ");
                }
                else if (thirdNb > 0)
                {
                    Console.WriteLine(" + ");
                }
            }
        }
    }
}

