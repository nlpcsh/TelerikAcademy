// Task 16 - Using loops write a program that converts an integer number to its
//    hexadecimal representation.
//  The input is entered as long. The output should be a variable of type string.
//  Do not use the built-in .NET functionality.

using System;
using System.Collections.Generic;

class DecimalToHexadecimalNb
{
    static void Main()
    {
        Console.Write(" Enter the Decimal number, please: ");
        long decimalNb = long.Parse(Console.ReadLine());
        long reminder = 0;
        string hexadecimalString = "";
        string stringDigit = "";

        while (decimalNb > 0)
        {
            reminder = decimalNb % 16;
            decimalNb = decimalNb / 16;

            switch (reminder)
            {
                case 10:
                    stringDigit = "A";
                    break;
                case 11:
                    stringDigit = "B";
                    break;
                case 12:
                    stringDigit = "C";
                    break;
                case 13:
                    stringDigit = "D";
                    break;
                case 14:
                    stringDigit = "E";
                    break;
                case 15:
                    stringDigit = "F";
                    break;
                default:
                    stringDigit = reminder.ToString();
                    break;
            }
            hexadecimalString = stringDigit + hexadecimalString;
        }
        Console.WriteLine(hexadecimalString);
    }
}

