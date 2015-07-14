namespace Task_5.Search_in_Bits
{
    using System;

    public class SearchInBits
    {
        public static void Main()
        {
            const byte NbBytes = 4;
            const byte PositionsOfBytes = 30;

            byte occurrence = 0;

            byte searchedNumber = byte.Parse(Console.ReadLine());
            byte inputNumbers = byte.Parse(Console.ReadLine());

            string searchedAsString = Convert.ToString(searchedNumber, 2).PadLeft(4, '0');

            for (int n = 0; n < inputNumbers; n++)
            {
                int inputNb = int.Parse(Console.ReadLine());
                string stringOfInputNb = Convert.ToString(inputNb, 2).PadLeft(30, '0');

                // j - starting position in the initial number's string array
                for (int j = 0; j < PositionsOfBytes - NbBytes + 1; j++)
                {
                    byte numberOfMatches = 0;

                    // cycle on every 4 bits 
                    for (int i = 0; i < NbBytes; i++)
                    {
                        if (stringOfInputNb[j + i] == searchedAsString[i])
                        {
                            numberOfMatches++;
                        }
                    }

                    if (numberOfMatches == 4)
                    {
                        occurrence++;
                    }
                }
            }

            Console.WriteLine(occurrence);
        }
    }
}
