namespace Task_2.MethodPrintStatistics
{
    using System;

    internal class Program
    {
        public void PrintStatistics(double[] importantNumbers)
        {
            double maxValue = importantNumbers[0];
            int lenght = importantNumbers.Length;

            for (int i = 0; i < lenght; i++)
            {
                if (importantNumbers[i] > maxValue)
                {
                    maxValue = importantNumbers[i];
                }
            }

            this.PrintResult(maxValue);

            double minValue = importantNumbers[0];

            for (int i = 0; i < lenght; i++)
            {
                if (importantNumbers[i] < minValue)
                {
                    minValue = importantNumbers[i];
                }
            }

            this.PrintResult(minValue);

            double sumOfElements = 0;

            for (int i = 0; i < lenght; i++)
            {
                sumOfElements += importantNumbers[i];
            }

            double averagedValue = sumOfElements / lenght;

            this.PrintResult(averagedValue);
        }

        private void PrintResult(double result)
        {
            Console.WriteLine("The result is: {0}", result);
        }
    }
}
