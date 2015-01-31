using System;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string strNumber = Console.ReadLine();
        int counter = 0;
        int sum = 0;
        int totalOddDigits = 0;

        foreach (char digit in strNumber)
        {
            if (counter % 2 == 1)
            {
                string stringDigit = Convert.ToString(digit);
                int tmpVar = int.Parse(stringDigit);

                sum += tmpVar;
                totalOddDigits++;
            }
            counter++;
        }
        Console.WriteLine(totalOddDigits + " " + sum);
    }
}

