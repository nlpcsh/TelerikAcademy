/* Problem 5. 64 Bit array

Define a class BitArray64 to hold 64 bit values inside an ulong value.
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 */

namespace Task05_64_Bit_array
{
    using System;

    class RunProgram
    {
        static void Main()
        {
            BitArray64 myTestBitArray = new BitArray64(4312321);

            foreach (var item in myTestBitArray)
            {
                Console.Write("{0}", item);
            }
            Console.WriteLine();
        }
    }
}
