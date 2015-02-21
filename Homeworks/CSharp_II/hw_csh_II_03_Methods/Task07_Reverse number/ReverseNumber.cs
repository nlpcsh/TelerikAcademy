// Task 7 - Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write(" Enter decimal number: ");
        string number = Console.ReadLine();

        ReverseNb(number);
    }

    static void ReverseNb(string number)
    {
        char[] charArray = number.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
        //return new string(charArray);
    }
}

