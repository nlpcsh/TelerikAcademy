// Task 2 - Which of the following values can be assigned to a variable of type float and
//    which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//  Write a program to assign the numbers in variables and print them to ensure 
//    no precision is lost.

// float (±1.5 × 10^−45 to ±3.4 × 10^38): 32-bits, precision of 7 digits
// double (±5.0 × 10^−324 to ±1.7 × 10^308): 64-bits, precision of 15-16 digits
// The default value of floating-point types:
//   float type  0.0F  
//   double type 0.0D  



using System;

class Program
{
    static void Main()
    {
        double first = 34.567839023;
        float second = 12.345F;
        double third = 8923.1234857;
        float forth = 3456.091F;

        Console.WriteLine(" Number to check is 34.567839023 <-> {0}", first);
        Console.WriteLine(" Number to check is 12.345 <-> {0}", second);
        Console.WriteLine(" Number to check is 8923.1234857 <-> {0}", third);
        Console.WriteLine(" Number to check is 3456.091 <-> {0}", forth);

    }
}

