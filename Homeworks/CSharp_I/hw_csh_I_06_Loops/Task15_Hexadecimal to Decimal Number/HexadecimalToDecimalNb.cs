// Task 15 -  Using loops write a program that converts a hexadecimal integer 
//    number to its decimal form.
//  The input is entered as string. The output should be a variable of type long.
//  Do not use the built-in .NET functionality.

using System;
using System.Globalization;

class HexadecimalToDecimalNb
{
    static void Main()
    {
        Console.Write(" Enter the Hexadecimal number, please: ");
        string hexaNumber = Console.ReadLine();
        string charTostring = "";
        int charCounter = 0;
        int currentDigit = 0;
        long number = 0;

        //// Variant 1 - using built-in .NET functionality
        //long num = Int32.Parse(hexaNumber, NumberStyles.HexNumber);
        //Console.WriteLine(num);

        //// Variant 2
        // get the number of digits
        foreach (char digit in hexaNumber)
        {
            charCounter++;
        }

        foreach (char digit in hexaNumber)
        {
            charCounter -= 1;

            switch (digit)
            {
                case 'A':
                case 'a':
                    currentDigit = 10;
                    break;
                case 'B':
                case 'b':
                    currentDigit = 11;
                    break;
                case 'C':
                case 'c':
                    currentDigit = 12;
                    break;
                case 'D':
                case 'd':
                    currentDigit = 13;
                    break;
                case 'E':
                case 'e':
                    currentDigit = 14;
                    break;
                case 'F':
                case 'f':
                    currentDigit = 15;
                    break;
                default:
                    charTostring = Convert.ToString(digit);
                    currentDigit = int.Parse(charTostring);
                    break;
            }

            if (currentDigit != 0)
            {
                int powerOf16 = 1;

                // make certain power of 16 depending on positon of the digit
                for (int j = 1; j <= charCounter; j++)
                {
                    powerOf16 *= 16;
                }
                currentDigit *= powerOf16;
                number += currentDigit;
            }

        }
        Console.WriteLine(number);
    }
}

