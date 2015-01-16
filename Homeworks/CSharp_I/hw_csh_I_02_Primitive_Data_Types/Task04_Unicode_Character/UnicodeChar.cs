// Task 4 - Unicode Caracter
//   Declare a character variable and assign it with the symbol that has 
//   Unicode code 42 (decimal) using the \u00XX syntax, and then print it.

using System;

class Program
{
    static void Main()
    {
        char variable = '\u002A' ;
        Console.WriteLine(" The variable is: {0} ", variable);
    }
}

