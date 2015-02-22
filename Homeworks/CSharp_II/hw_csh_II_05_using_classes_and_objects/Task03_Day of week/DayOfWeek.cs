// Task 3 - Write a program that prints to the console which day of the week is today.
//   Use System.DateTime.

using System;

class DayOfWeek
{
    static void Main()
    {
        DateTime today = DateTime.Now;

        string dayOfweek = string.Empty;

        switch ((byte)today.DayOfWeek)
        {
            case 0: dayOfweek = "Sunday"; break;
            case 1: dayOfweek = "Monday"; break;
            case 2: dayOfweek = "Tuesday"; break;
            case 3: dayOfweek = "Wednesday"; break;
            case 4: dayOfweek = "Thurstay"; break;
            case 5: dayOfweek = "Friday"; break;
            case 6: dayOfweek = "Saturday"; break;
            default:
                break;
        }

        Console.WriteLine("Today is {0}", dayOfweek);
    }
}

