namespace Task1_CompareThreeNumbers
{
    using System;

    /// <summary>
    /// Compares 3 numbers and finds the averaged
    /// </summary>
    internal class ThreeNumbersCompareror
    {
        internal static void Main()
        {
            double a = ReadInputNumber();
            double b = ReadInputNumber();
            double c = ReadInputNumber();

            double biggestNumber = a;

            if (biggestNumber - b < 0)
            {
                biggestNumber = b;
            }

            if (biggestNumber - c < 0)
            {
                biggestNumber = c;
            }

            Console.WriteLine(biggestNumber);

            double smallestNumber = a;

            if (smallestNumber - b > 0)
            {
                smallestNumber = b;
            }

            if (smallestNumber - c > 0)
            {
                smallestNumber = c;
            }

            Console.WriteLine(smallestNumber);

            double averegedOfThree = (a + b + c) / 3;
            Console.WriteLine("{0:F2}", averegedOfThree);
        }

        private static double ReadInputNumber()
        {
            try
            {
                double input = double.Parse(Console.ReadLine());
                return input;
            }
            catch (FormatException)
            {
                throw new FormatException("The input is not a number!");
            }
        }
    }
}