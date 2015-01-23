// Task 13 - Write a Boolean expression that returns if the bit at position p 
//  (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckBit
{
    static void Main()
    {
        Console.Write(" Enter a number to extract a bit: ");
        int varToExtractBit = int.Parse(Console.ReadLine());
        Console.Write(" Enter a bit number to compare: ");
        int bit = int.Parse(Console.ReadLine());

        int maskP = 1 << bit;
        int nAndMask = varToExtractBit & maskP;

        int b = nAndMask >> bit;

        Console.WriteLine(" The bit {0} with number {1} compared to 1 is: {2}", b, bit, b == 1);
    }
}

