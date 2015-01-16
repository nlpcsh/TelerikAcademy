// Task 1 - Write an expression that checks if given integer is odd or even.

using System;

namespace hw_csh_I_03_Operators_and_Expressions
{
    class OddEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to check ");
            int toCheck = int.Parse(Console.ReadLine());

            Console.WriteLine((toCheck % 2) == 0 ? "The Number is EVEN! " : "The Number is ODD! ");

        }
    }
}
