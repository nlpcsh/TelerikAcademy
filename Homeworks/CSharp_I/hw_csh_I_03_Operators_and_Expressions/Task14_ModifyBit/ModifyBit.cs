// Task 14 - We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//   Write a sequence of operators (a few lines of C# code) that modifies n to hold the 
//   value v at the position p from the binary representation of n while preserving all 
//   other bits in n.

using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write(" Enter a number to change a bit in it: ");
        int varToExtractBit = int.Parse(Console.ReadLine());
        Console.Write(" Enter a bit number that has to be changed: ");
        int bitNumber = int.Parse(Console.ReadLine());
        Console.Write(" Enter a bit value to set: ");
        byte bitValue = byte.Parse(Console.ReadLine());

        int result = 0;
        if (bitValue == 0)
        {
            int mask = ~(1 << bitNumber);
            result = varToExtractBit & mask;
        }
        else if (bitValue == 1)
        {
            int mask = 1 << bitNumber;
            result = varToExtractBit | mask;
        }
        else
        {
            Console.WriteLine(" The bit value is not 0 or 1... ");
            Environment.Exit(1);
        }
        
        Console.WriteLine(" New number is: {0}", result);
    }
}

