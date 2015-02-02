using System;

class TheHorror
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        long sum = 0;
        int counter = 0;
        long counterEven = 0;

        foreach (char digit in inputText)
        {
            if (digit >= '0' && digit <= '9')
            {
                if (counter % 2 == 0)
                {
                    sum += digit - '0';
                    counterEven++;
                }
            }
            counter++;
        }
        Console.WriteLine("{0} {1}", counterEven, sum);
    }
}


