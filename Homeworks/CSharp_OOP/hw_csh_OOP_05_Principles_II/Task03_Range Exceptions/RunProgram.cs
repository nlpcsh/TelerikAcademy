/* Problem 3. Range Exceptions

Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
 */

namespace Task03_Range_Exceptions
{
    using System;

    class RunProgram
    {
        static void Main()
        {
            // test int
            int[] someNumbers = { 1, 20, 30, 1000 };

            foreach (int number in someNumbers)
            {
                try
                {
                    if (100 < number || number < 0)
                    {
                        throw new InvalidRangeException<int>(0, 100);
                    }

                    Console.WriteLine("{0} is in the range", number);
                }
                catch (InvalidRangeException<int> ex)
                {
                    Console.WriteLine("Number {0} {1}", number, ex.Message);
                }
            } 
            Console.WriteLine();


            // test date
            DateTime[] someDates = { new DateTime(1999, 12, 25), DateTime.Now };
            DateTime startDate = new DateTime(1980, 1, 1, 0, 0, 0);
            DateTime endDate = new DateTime(2013, 12, 31, 23, 59, 59);

            foreach (DateTime date in someDates)
            {
                try
                {
                    if (startDate > date || date > endDate)
                    {
                        throw new InvalidRangeException<DateTime>(startDate, endDate);
                    }
                    Console.WriteLine("{0:D} is in the range", date);
                }
                catch (InvalidRangeException<DateTime> ex)
                {
                    Console.WriteLine("{0:D} {1}", date, ex.Message);
                }
            }

        }
    }
}
