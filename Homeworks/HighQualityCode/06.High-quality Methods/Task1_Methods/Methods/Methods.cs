namespace Methods
{
    using System;

    internal class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides of the triangle should be positive.");
            }

            if ((a + b < c) || (c + b < a) || (c + a < b))
            {
                throw new ArgumentException("The triangle is not possible due to one of the sides.");
            }

            double area = 0;

            checked
            {
                double halfPerimeter = (a + b + c) / 2;

                area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            }

            return area;
        }

        public static string NumberToDigit(int number)
        {
            if ((number < 0) || (9 < number))
            {
                throw new ArgumentException("Input number must be a digit!");
            }

            string digitAsString = string.Empty;

            switch (number)
            {
                case 0: digitAsString = "zero";
                    break;
                case 1: digitAsString = "one"; 
                    break;
                case 2: digitAsString = "two";
                    break;
                case 3: digitAsString = "three"; 
                    break;
                case 4: digitAsString = "four";
                    break;
                case 5: digitAsString = "five";
                    break;
                case 6: digitAsString = "six"; 
                    break;
                case 7: digitAsString = "seven"; 
                    break;
                case 8: digitAsString = "eight";
                    break;
                case 9: digitAsString = "nine";
                    break;
                default: digitAsString = "Invalid number!";
                    break;
            }

            return digitAsString;
        }

        public static int FindMax(params int[] elements)
        {
            if (elements.Length == 0 || elements == null)
            {
                throw new ArgumentNullException("Input array must have at least 1 element!");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        public static void PrintAsNumber(object number, string format)
        {
            decimal numberToFormat = 0;

            try
            {
                string numberToString = number.ToString();
                numberToFormat = decimal.Parse(numberToString);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Input object is not an number!");
            }

            if (format == "f")
            {
                Console.WriteLine("{0:f2}", numberToFormat);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", numberToFormat);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", numberToFormat);
            }
            else
            {
                throw new ArgumentException("Format to print the number is wrong!");
            }
        }
        
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }

        public static bool IsOneDimetional(double d1, double d2)
        {
            const double AcceptableDifference = 0.0000001;
            bool isOneDimetional = Math.Abs(d1 - d2) < AcceptableDifference;

            return isOneDimetional;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));

            bool horizontal = IsOneDimetional(3, 3);
            bool vertical = IsOneDimetional(-1, 2.5);
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov");
            peter.DateOfBirth = "17.04.1993";
            peter.Town = "Sofia";

            Student stella = new Student("Stella", "Markova");
            stella.DateOfBirth = "08.03.1992";
            stella.Town = "Vidin";
            stella.OtherInfo = "gamer, high results";
            Console.WriteLine(stella.ToString());

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
