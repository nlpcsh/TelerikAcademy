namespace Task_3.Compare_Advanced_Maths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    internal class AdvancedMath
    {
        public static void Main()
        {
            string[] operations = new string[3] { "SquareRoot", "Ln", "Sin" };

            foreach (var ch in operations)
            {
                CompareMathOperations(3f, ch);
                CompareMathOperations(3d, ch);
                CompareMathOperations(3m, ch);

                Console.WriteLine("-------------------");
            }
        }

        private static T Sqrt<T>(T number)
        {
            T epsilon = (dynamic)0;

            if (number.GetType() == typeof(float))
            {
                epsilon = (dynamic)(float)1.0e-7;
            }
            else if (number.GetType() == typeof(double))
            {
                epsilon = (dynamic)1.0e-15;
            }
            else if (number.GetType() == typeof(decimal))
            {
                epsilon = (dynamic)(decimal)1.0e-28;
            }
            else
            {
                throw new NotImplementedException("Not implemented for different than 'decimal', 'double' and 'float' data types!");
            }

            //// closer to sqrt of number
            T sqrt = (dynamic)2;

            T delta = (dynamic)1;

            while (delta > (dynamic)epsilon)
            {
                delta = sqrt;
                sqrt = (sqrt + (dynamic)number / sqrt) / 2;
                delta -= (dynamic)sqrt;
                //Console.WriteLine("sqrt = {0}, delta = {1}", sqrt, delta);
            }

            return sqrt;
        }

        public static void CompareMathOperations<T>(T number, string operation)
        {
            var totalCalcTime = new List<TimeSpan>();

            T value = (dynamic)0;

            for (int times = 0; times < 10; times++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();

                for (int i = 0; i < 100000; i++)
                {
                    switch (operation)
                    {
                        case "SquareRoot": value = Sqrt(number);
                            break;
                        case "Ln": ; // Ln(number);
                            break;
                        case "Sin": value = Sin(number);
                            break;
                        default: Console.WriteLine("Operation not possible!");
                            break;
                    }
                }

                sw.Stop();
                totalCalcTime.Add(sw.Elapsed);
            }

            Console.WriteLine(" Averaged time for {0} operation of type {1} is: \n  {2} [s-3],  value is: {3}", operation, typeof(T), totalCalcTime.Average(x => x.Milliseconds), value);
        }

        private static void SquareRootFloat(float number)
        {
            /*
                  find more detail of this method on wiki methods_of_computing_square_roots

                  *** Babylonian method cannot get exact zero but approximately value of the quare_root
             */
            float z = number;
            float rst = 0f;
            float j = 1f;
            float powerOfTenValue = 0f;
            byte max = 7;

            for (byte i = max; i > 0; i--)
            {
                powerOfTenValue = powerOfTenFloat(i);

                // value must be bigger then 0
                if (z - ((2f * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0f)
                {
                    while (z - ((2f * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0f)
                    {
                        j += 1f;

                        if (j >= 10f)
                        {
                            break;
                        }
                    }

                    j -= 1f; //correct the extra value by minus one to j
                    z -= ((2f * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue); //find value of z

                    rst += j * powerOfTenValue;     // find sum of a

                    j = 1f;
                }
            }

            for (int i = 0; i >= 0 - max; i--)
            {
                powerOfTenValue = powerOfTenFloat(i);

                if (z - ((2f * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0f)
                {
                    while (z - ((2f * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0f)
                    {
                        j += 1f;
                    }

                    j -= 1f;
                    z -= ((2f * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue); //find value of z

                    rst += j * powerOfTenValue;     // find sum of a
                    j = 1f;
                }
            }
            //Console.WriteLine(rst);
            // find the number on each digit
            //return rst;
        }

        private static float powerOfTenFloat(int num)
        {
            float rst = 1;
            if (num >= 0)
            {
                for (int i = 0; i < num; i++)
                {
                    rst *= 10.0f;
                }
            }
            else
            {
                for (int i = 0; i < (0 - num); i++)
                {
                    rst *= 0.1f;
                }
            }

            return rst;
        }

        private static T Ln<T>(T power)
        {
            T eBbase = (dynamic)Math.E;
            T Whole, n, Sign;
            Sign = (dynamic)1;

            #region Error Checking
            if (power <= (dynamic)1 || eBbase <= (dynamic)1)
            {
                if (power <= (dynamic)0 || eBbase <= (dynamic)0)
                {
                    return (dynamic)0;
                }
                if (power < (dynamic)1)
                {
                    power = (dynamic)1 / power;
                    Sign *= (dynamic)(-1);
                }
                if (eBbase < (dynamic)1)
                {
                    Sign *= (dynamic)(-1);
                    eBbase = (dynamic)1 / eBbase;
                }
                if (power == (dynamic)1)
                {
                    if (eBbase != (dynamic)1)
                    {
                        return (dynamic)0;
                    }
                    return (dynamic)1;
                }
            }
            #endregion

            Whole = power;
            n = (dynamic)0;

            while ((dynamic)power >= eBbase)
            {
                power /= (dynamic)eBbase;
                n += (dynamic)1;
            }
            if (power == (dynamic)1)
            {
                //return (Sign * n);
                Console.WriteLine(n);
            }

            return Sign * (n + ((dynamic)1 / Ln(eBbase)));
        }

        private static T Sin<T>(T angle)
        {

            T pi = (dynamic)0;

            //// precision of calculation
            byte precision = 1;

            if (pi.GetType() == typeof(float))
            {
                pi = (dynamic)3.1415926535897932384626433832795028841971693993751f;
                precision = 7;
            }
            else if (pi.GetType() == typeof(double))
            {
                pi = (dynamic)3.1415926535897932384626433832795028841971693993751d;
                precision = 15;
            }
            else if (pi.GetType() == typeof(decimal))
            {
                pi = (dynamic)3.1415926535897932384626433832795028841971693993751m;
                precision = 27;
            }
            else
            {
                throw new NotImplementedException("Not implemented for different than 'decimal', 'double' and 'float' data types!");
            }


            T angleRads = (angle / (dynamic)180) * pi;
            T sinus = angleRads;
            T taylorsPart = (dynamic)angleRads * angleRads;


            //// formula is:
            //// sinus = angleRads - angleRads^3 / 3! + angleRads^5 / 5! - angleRads^7 / 7! ....;
            for (int i = 3; i <= precision; i += 2)
            {
                for (int j = i - 1; j <= i; j++)
                {
                    taylorsPart *= (dynamic)(-1) * angleRads / j;
                }
                sinus = sinus + (dynamic)taylorsPart;
            }

            return sinus;
            //Console.WriteLine(sinus);
        }

        private static T CalculateFactoriel<T>(T upTo)
        {
            T factoriel = (dynamic)1;

            for (int i = 1; (dynamic)i <= upTo; i++)
            {
                factoriel *= (dynamic)i;
            }

            return factoriel;
        }

    }
}
