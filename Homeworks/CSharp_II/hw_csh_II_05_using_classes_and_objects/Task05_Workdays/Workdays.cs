// Task 5 - Write a method that calculates the number of workdays 
//    between today and given date, passed as parameter.
//  Consider that workdays are all days from Monday to Friday except
//    a fixed list of public holidays specified preliminary as array.

using System;

class Workdays
{
    static DateTime[] Holidays = {
                 new DateTime(2015,03,03),
                 new DateTime(2015,10,04),
                 new DateTime(2015,01,05),
                 new DateTime(2015,06,05),
                 new DateTime(2015,01,15),
                 new DateTime(2015,06,22),
                 new DateTime(2015,12,25),
                 new DateTime(2015,12,31)
                                 };
    static void Main()
    {
        DateTime dateNow = DateTime.Now;

        Console.WriteLine(" Enter date in format: YYYY,MM,DD: ");
        string[] dateStr = Console.ReadLine().Split(',');
        int year = int.Parse(dateStr[0]);
        int day = int.Parse(dateStr[2]);
        int month = int.Parse(dateStr[1]);

        DateTime endDate = new DateTime(year, month, day);

        Console.WriteLine("There are {0} working days from {1} to {2}", WorkingDays(dateNow, endDate), dateNow, endDate);
    }

    static int WorkingDays(DateTime dateNow, DateTime targetDate)
    {
        int daysLenght = Math.Abs((dateNow - targetDate).Days);
        int counter = daysLenght;

        if (dateNow > targetDate)
        {
            dateNow = targetDate;
            targetDate = DateTime.Now;
        }

        for (int i = 0; i < daysLenght; i++)
        {
            dateNow = dateNow.AddDays(1);

            if (dateNow.DayOfWeek == DayOfWeek.Sunday || dateNow.DayOfWeek == DayOfWeek.Saturday)
            {
                counter--;
            }

            for (int days = 0; days < Holidays.Length; days++)
            {
                if (dateNow.CompareTo(Holidays[days]) == 0)
                {
                    counter--;
                }
            }
        }

        return counter;
    }
}

