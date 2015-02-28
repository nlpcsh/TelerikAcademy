/* Task 2 
    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
        If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

using System;

class EnterNumbers
{
    static void Main()
    {
        int countNumbers = 10;
        int start = 1;
        int end = 100;
        Console.WriteLine("Please enter 10 integer numbers in range [1,100]:");
        for (int i = 0; i < countNumbers; i++)
        {
            ReadNumber(start, end);
        }

    }

    static void ReadNumber(int start, int end)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine("The number is VALID.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number in not in the range (1;100)");
        }
        catch (FormatException)
        {
            Console.WriteLine("The number in not in valid format!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big !");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("You have entered nothing!");
        }
    }
}

