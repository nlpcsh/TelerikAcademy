// Task 6 - Four-Digit Number
//
//  Write a program that takes as input a four-digit number in format abcd 
//   (e.g. 2011) and performs the following:
//    - Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//    - Prints on the console the number in reversed order: dcba (in our example 1102).
//    - Puts the last digit in the first position: dabc (in our example 1201).
//    - Exchanges the second and the third digits: acbd (in our example 2101).
//
// The number has always exactly 4 digits and cannot start with 0.

using System;
using System.Linq;

class FourDigitNumber
{
    static void Main()
    {
        // digits from right to left:
        int[] digits ;
        digits = new int[4] ;
        bool isTrue = true;

        Console.Write(" Enter a four digit number, please: ");
        int fourDigitNumber = int.Parse(Console.ReadLine());

        // Check if the number contains 4 digits
        while (isTrue)
        {
            if ((9999 - Math.Abs(fourDigitNumber) < 0 ) ^ ( Math.Abs(fourDigitNumber) - 999 <= 0))
            {
                Console.Write("It is not a four digit number. Try again: ");
                fourDigitNumber = int.Parse(Console.ReadLine());
            }
            else
            {
                isTrue = false; 
            }
        }

        // Take all of the digits in one integer array
        for (int i = 0; i < 4; i++)
        {
            digits[i] = fourDigitNumber % 10;
            fourDigitNumber = fourDigitNumber / 10;
            Console.WriteLine(" Array elemt {0} is {1}", i, digits[i]);
        }

        // Take the summe of the array elements
        int sumOfDigits = digits.Sum();
        Console.WriteLine(" Summe of the digits is: {0}", sumOfDigits);

        // print the number in different order:
        Console.WriteLine(" The number printed in reverced order is  : {0}{1}{2}{3}", digits[0], digits[1], digits[2], digits[3]);
        Console.WriteLine(" The last digit in the first position     : {0}{1}{2}{3}", digits[0], digits[3], digits[2], digits[1]);
        Console.WriteLine(" Exchanged the second and the third digits: {0}{1}{2}{3}", digits[3], digits[1], digits[2], digits[0]);
    }
}
