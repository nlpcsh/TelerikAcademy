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
            if (digit >= '0' && digit <= '9')
            {
                if (counter % 2 == 1)
                {
                    sum += digit - '0';
                    totalOddDigits++;
                }
            }
            counter++;
        }
        Console.WriteLine(totalOddDigits + " " + sum);
    }
}

