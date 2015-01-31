// Task 13 - Using loops write a program that converts a binary integer number
//    to its decimal form.
//   The input is entered as string. The output should be a variable of type long.
//   Do not use the built-in .NET functionality.

using System;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        Console.Write(" Enter the binary number, please: ");
        string binaryNb = Console.ReadLine();

        int charCounter = 0;

        // Test the input string 
        bool notBinary = true;

        while (notBinary)
        {
            int bitCounter = 0;

            foreach (char b in binaryNb)
            {
                if (b == '1' || b == '0')
                {
                    bitCounter++;
                }
                charCounter++;
            }

            if (bitCounter != charCounter)
            {
                Console.WriteLine(" Not a binary number! ");
                //Environment.Exit(1);
                Console.Write(" Enter the BINARY number, please: ");
                binaryNb = Console.ReadLine();
            }
            else
            {
                notBinary = false;
            }
        }
        // End of input test !

        long decimalResult = 0;

        // start to count characters in the string from 0 and from left to right
        charCounter--;

        foreach (char b in binaryNb)
        {
            if (b == '1')
            {
                int powerOf2 = 1;

                // make certain power of 2 depending on positon of the bit
                for (int j = 0; j < charCounter; j++)
                {
                    powerOf2 *= 2;
                }
                decimalResult += powerOf2;
            }

            // move position of the bit to the right
            charCounter--;
        }

        Console.WriteLine(" Decima value of the number is: {0}", decimalResult);
    }
}

