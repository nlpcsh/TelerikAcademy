// Task 5 - Write an expression that checks for given integer if 
//   its third digit from right-to-left is 7.

using System;

class Third_Digit_is_7
{
    static void Main()
    {
        Console.Write(" Enter a number to check if its third digit is 7: ");
        float toCheck = float.Parse(Console.ReadLine());

        toCheck = (int)toCheck / 100;

        int thirdDigit = (int)toCheck % 10;

        Console.WriteLine((thirdDigit % 7 == 0) ? " ...it is 7! " : " ...it is NOT 7! ");
    }
}

