namespace CSharp2Exam
{
    using System;
    using System.Linq;

    internal class DecreasingAbsoluteDifferences
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int[] intNumbers = Console.ReadLine()
                              .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();

                int[] absoluteDifference = FindDifference(intNumbers);

                FindIfDecreasing(absoluteDifference);
            }
        }

        private static void FindIfDecreasing(int[] absoluteDifference)
        {
            bool isDecreasing = true;

            for (int i = 0; i < absoluteDifference.Length - 1; i++)
            {
                if (absoluteDifference[i] - absoluteDifference[i + 1] < 0)
                {
                    isDecreasing = false;
                }

                if (absoluteDifference[i] - absoluteDifference[i + 1] >= 2)
                {
                    isDecreasing = false;
                }
            }

            Console.WriteLine(isDecreasing);
        }

        private static int[] FindDifference(int[] intNumbers)
        {
            int[] absoluteDiff = new int[intNumbers.Length - 1];

            for (int i = 0; i < absoluteDiff.Length; i++)
            {
                absoluteDiff[i] = Math.Abs(intNumbers[i] - intNumbers[i + 1]);
            }

            return absoluteDiff;
        }
    }
}