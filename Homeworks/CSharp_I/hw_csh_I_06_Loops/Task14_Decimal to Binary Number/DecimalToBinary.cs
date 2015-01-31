// Task 14 - Using loops write a program that converts an integer number to its
//    binary representation.
//  The input is entered as long. The output should be a variable of type string.
//  Do not use the built-in .NET functionality.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write(" Enter the decimal number, please: ");
        int number = int.Parse(Console.ReadLine());
        int reminder = 0;
        string binaryString = "";

        while (number > 0)
        {
            reminder = number % 2;
            number = number / 2;
            binaryString = reminder.ToString() + binaryString;
        }

        Console.WriteLine("Its binary representation is: {0}", binaryString);
    }
}

