// Task 1 - Write an if-statement that takes two double variables a and b and exchanges 
//   their values if the first one is greater than the second one. As a result print the 
//   values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter first variable: ");
        double firstNb = double.Parse(Console.ReadLine());
        Console.Write("Enter second variable: ");
        double secondNb = double.Parse(Console.ReadLine());

        if (firstNb > secondNb)
        {
            double toExchange = firstNb;
            firstNb = secondNb;
            secondNb = toExchange;
        }
        Console.WriteLine(" In increasing order values are: {0} {1}", firstNb, secondNb);
    }
}

