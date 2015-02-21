// Task 3 - Write a method that returns the last digit of given integer as 
//   an English word.

using System;
using System.Linq;

class EnglishDigit
{
    static void Main()
    {
        Console.Write(" Enter an int number: ");
        int number = int.Parse(Console.ReadLine());

        LastDigitToText(number);
    }

    static void LastDigitToText(int number)
    {
        int lastDigit = number % 10;
        string digitWord = string.Empty;

        switch (lastDigit)
        {
            case 1: digitWord = "one";
                break;
            case 2: digitWord = "two";
                break;
            case 3: digitWord = "three";
                break;
            case 4: digitWord = "four";
                break;
            case 5: digitWord = "five";
                break;
            case 6: digitWord = "six";
                break;
            case 7: digitWord = "seven";
                break;
            case 8: digitWord = "eight";
                break;
            case 9: digitWord = "nine";
                break;
            case 0: digitWord = "zero";
                break;
            default:
                break;
        }

        Console.WriteLine(" Last digit is: {0}", digitWord);
    }
}

