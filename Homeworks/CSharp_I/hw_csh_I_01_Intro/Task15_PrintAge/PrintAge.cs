// Task 15 - Write a program to read your birthday from the console and 
//   print how old you are now and how old you will be after 10 years.

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        CultureInfo bg = new CultureInfo("bg-BG");
        Thread.CurrentThread.CurrentCulture = bg;

        DateTime now = DateTime.Now;
        Console.WriteLine(" Today is: {0}", DateTime.Now);
        Console.Write(" Enter your birthday, please (day, month, year): ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());

        int years = now.Year - birthday.Year;
        int monts = now.Month - birthday.Month;
        int days = now.Day - birthday.Day ;

        if (monts < 0)
        {
            years = years - 1;
            monts = monts + 12;
        }
        if (days < 0)
        {
            monts = monts - 1;
            days = days + 30;
        }
        if (years < 0)
        {
            Console.WriteLine(" Sorry, you aren't born yet! ");
        }
        else
        {
            Console.WriteLine("Your age after 10 years will be {0} years, {1} months and {2} days old.", years + 10, monts, days);
        }
    }
}
