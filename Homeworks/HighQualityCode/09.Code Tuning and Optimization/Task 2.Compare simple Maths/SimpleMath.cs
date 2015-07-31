namespace Task_2.Compare_simple_Maths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    internal class SimpleMath
    {
        public static void Main()
        {
            char[] operations = new char[4] { '+', '-', '*', '/' };

            foreach (var ch in operations)
            {
                CompareMathOperations(1, ch);
                CompareMathOperations(1L, ch);
                CompareMathOperations(1f, ch);
                CompareMathOperations(1d, ch);
                CompareMathOperations(1m, ch);

                Console.WriteLine("-------------------");
            }
        }

        public static void CompareMathOperations<T>(T number, char operation)
        {
            var totalCalcTime = new List<TimeSpan>();

            for (int times = 0; times < 10; times++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();

                for (int i = 0; i < 1000000; i++)
                {
                    switch (operation)
                    {
                        case '+': AddOperation(number);
                            break;
                        case '-': SubstractOperation(number);
                            break;
                        case '*': MultOperation(number);
                            break;
                        case '/': DivideOperation(number);
                            break;
                        default: Console.WriteLine("Operation not possible!");
                            break;
                    }
                }

                sw.Stop();
                totalCalcTime.Add(sw.Elapsed);
            }

            Console.WriteLine(" Averaged time for {0} operation of type {1} is: {2} s-3", operation, typeof(T), totalCalcTime.Average(x => x.Milliseconds));
        }

        private static void AddOperation<T>(T number)
        {
            number += (dynamic)1;
        }

        private static void SubstractOperation<T>(T number)
        {
            number -= (dynamic)1;
        }

        private static void MultOperation<T>(T number)
        {
            number *= (dynamic)2;
        }

        private static void DivideOperation<T>(T number)
        {
            number /= (dynamic)2;
        }
    }
}
