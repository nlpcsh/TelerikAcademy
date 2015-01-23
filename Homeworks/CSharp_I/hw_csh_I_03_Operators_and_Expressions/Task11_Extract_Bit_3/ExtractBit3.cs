// Task 11 - Using bitwise operators, write an expression for finding the value of 
//   the bit #3 of a given unsigned integer.
//  The bits are counted from right to left, starting from bit #0.
//  The result of the expression should be either 1 or 0.

using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write(" Enter a number to extract the third bit: ");
        uint varToExtractBit = uint.Parse(Console.ReadLine());

        uint maskP = 1 << 3;
        uint nAndMask = varToExtractBit & maskP;

        uint b = nAndMask >> 3;

        Console.WriteLine(" The third byte is: {0}", b);

    }
}

