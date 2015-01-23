// Task 4 - Write a program that gets two numbers from the console and 
//   prints the greater of them.
//   Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write(" Enter the first number: ");
        float firstNb = float.Parse(Console.ReadLine());
        Console.Write(" Enter the second number: ");
        float secondNb = float.Parse(Console.ReadLine());

        Console.Write(" Greater number is: " );
        Console.WriteLine((firstNb > secondNb) ? firstNb : secondNb );
    }
}
