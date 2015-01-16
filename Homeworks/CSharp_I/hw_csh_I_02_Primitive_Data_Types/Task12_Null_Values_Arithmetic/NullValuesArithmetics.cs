// Task 12 - Create a program that assigns null values to an integer and to a double variable.
//   Try to print these variables at the console.
//   Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullableVar1 = null;
        double? nullableVar2 = null;

        Console.WriteLine("First  value printed: {0}", nullableVar1);
        Console.WriteLine("Second value printed: {0}", nullableVar2);

        nullableVar1 = nullableVar1 + 1;
        nullableVar2 = nullableVar2 + 10;
        Console.WriteLine("First  value added to  1: {0}", nullableVar1 );
        Console.WriteLine("Second value added to 10: {0}", nullableVar2 );

    }
}

