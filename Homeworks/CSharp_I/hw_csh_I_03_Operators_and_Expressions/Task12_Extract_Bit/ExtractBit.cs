// Task 12 - Write an expression that extracts from given integer n the value of 
//   given bit at index p.

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write(" Enter a number to extract a bit from : ");
        int varToExtractBit = int.Parse(Console.ReadLine());
        Console.Write(" Enter a bit number to extract: ");
        int bit = int.Parse(Console.ReadLine());

        int maskP = 1 << bit;
        int nAndMask = varToExtractBit & maskP;

        int b = nAndMask >> bit;

        Console.WriteLine(" The bit {1} is: {0}", b, bit);
    }
}
