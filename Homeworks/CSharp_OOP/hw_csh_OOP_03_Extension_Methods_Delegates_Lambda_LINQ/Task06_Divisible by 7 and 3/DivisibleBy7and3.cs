/* Task 6 - Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 */

using System;
using System.Linq;

namespace Task06_Divisible_by_7_and_3
{
    class DivisibleBy7and3
    {
        static void Main()
        {
            var intArray = new int[] { 42, 4, 5, 7, 77, 33, 21, 105  };

            var resultLambda = intArray.Where(x => ((x % 3 == 0) && (x % 7 == 0)));

            Console.WriteLine(" Numbers divisible by 3 and 7 using Lambda Expr: \n {0}", string.Join(", ", resultLambda));

            Console.WriteLine();

            var resultLINQ = 
                from number in intArray
                where (number % 3 == 0) && (number % 7 == 0)
                select number;

            Console.WriteLine(" Numbers divisible by 3 and 7 using LINQ: \n {0}", string.Join(", ", resultLambda));

 
        }
    }
}
