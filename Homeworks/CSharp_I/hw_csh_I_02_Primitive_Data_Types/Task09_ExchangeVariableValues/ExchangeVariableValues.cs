﻿// Task 9 - Declare two integer variables a and b and assign them with 5 and 10 and
//   after that exchange their values by using some programming logic.
//  Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("First Values of a = {0}, and b = {1}", a, b);

        int exchangeValue = a;
        a = b;
        b = exchangeValue;
        Console.WriteLine( "Exchanged Values of a = {0}, and b = {1}", a, b);
    }
}

