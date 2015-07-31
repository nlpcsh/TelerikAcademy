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

        public static void CompareMathOperations<T>(T number, string operation)
        {
            var totalCalcTime = new List<TimeSpan>();

            for (int times = 0; times < 10; times++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();

                for (int i = 0; i < 100000; i++)
                {
                    switch (operation)
                    {
                        case "SquareRoot": SquareRoot(number);
                            break;
                        case "Ln": ; // Ln(number);
                            break;
                        case "Sin": Sin(number);
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

        /// <summary>
        /// Babylonian method to find square root
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="number"></param>
        private static void SquareRoot<T>(T number)
        {
            /*
                  find more detail of this method on wiki methods_of_computing_square_roots

                  *** Babylonian method cannot get exact zero but approximately value of the quare_root
             */

            if (number.GetType() == typeof(float))
            {
                SquareRootFloat((dynamic)number);
            }
            else if (number.GetType() == typeof(decimal))
            {
                // SquareRootDecimal((dynamic)number);
            }
            else
            {
                SquareRootDouble((dynamic)number);
            }
        }

        private static void SquareRootDouble(double number)
        {
            double z = number;
            double rst = 0d;
            double j = 1d;
            double powerOfTenValue = 0d;

            byte max = 15;

            for (byte i = max; i > 0; i--)
            {
                powerOfTenValue = powerOfTenDouble(i);

                // value must be bigger then 0
                if (z - ((2d * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0d)
                {
                    while (z - ((2d * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0d)
                    {
                        j += 1d;

                        if (j >= 10d)
                        {
                            break;
                        }
                    }

                    ////correct the extra value by minus one to j
                    j -= 1d;

                    ////find value of z
                    z -= ((2d * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue);

                    //// find sum of a
                    rst += j * powerOfTenValue;     

                    j = 1d;
                }
            }

            for (int i = 0; i >= 0 - max; i--)
            {
                powerOfTenValue = powerOfTenDouble(i);

                if (z - ((2 * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0d)
                {
                    while (z - ((2d * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0d)
                    {
                        j += 1d;
                    }

                    j -= 1d;
                    z -= ((2d * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue); //find value of z

                    rst += j * powerOfTenValue;     // find sum of a
                    j = 1d;
                }
            }
            //Console.WriteLine(rst);
            // find the number on each digit
            //return rst;
        }

        private static double powerOfTenDouble(int num)
        {
            double rst = 1;
            if (num >= 0)
            {
                for (int i = 0; i < num; i++)
                {
                    rst *= 10.0d;
                }
            }
            else
            {
                for (int i = 0; i < (0 - num); i++)
                {
                    rst *= 0.1d;
                }
            }

            return rst;
        }

        private static void SquareRootDecimal(decimal number)
        {
            /*
                  find more detail of this method on wiki methods_of_computing_square_roots

                  *** Babylonian method cannot get exact zero but approximately value of the quare_root
             */
            decimal z = number;
            decimal rst = 0m;
            decimal j = 1m;
            decimal powerOfTenValue = 0m;

            byte max = 28;    // to define maximum digit 

            for (byte i = max; i > 0; i--)
            {
                powerOfTenValue = powerOfTenDecimal(i);

                // value must be bigger then 0
                if (z - ((2m * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0m)
                {
                    while (z - ((2m * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0m)
                    {
                        j += 1m;

                        if (j >= 10m)
                        {
                            break;
                        }
                    }

                    j -= 1m; //correct the extra value by minus one to j
                    z -= ((2m * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue); //find value of z

                    rst += j * powerOfTenValue;     // find sum of a

                    j = 1m;
                }
            }

            for (int i = 0; i >= 0 - max; i--)
            {
                powerOfTenValue = powerOfTenDecimal(i);

                if (z - ((2m * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0m)
                {
                    while (z - ((2m * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue) >= 0m)
                    {
                        j += 1m;
                    }

                    j -= 1m;
                    z -= ((2m * rst) + (j * powerOfTenValue)) * (j * powerOfTenValue); //find value of z

                    rst += j * powerOfTenValue;     // find sum of a
                    j = 1m;
                }
            }
            //Console.WriteLine(rst);
            // find the number on each digit
            //return rst;
        }

        private static decimal powerOfTenDecimal(int num)
        {
            decimal rst = 1;
            if (num >= 0)
            {
                for (int i = 0; i < num; i++)
                {
                    rst *= 10.0m;
                }
            }
            else
            {
                for (int i = 0; i < (0 - num); i++)
                {
                    rst *= 0.1m;
                }
            }

            return rst;
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

        private static void Sin<T>(T angle)
        {

            T pi = (dynamic)0;
            if (pi.GetType() == typeof(float))
            {
                pi = (dynamic)3.1415926535897932384626433832795028841971693993751f;
            }
            else if (pi.GetType() == typeof(decimal))
            {
                pi = (dynamic)3.1415926535897932384626433832795028841971693993751m;
            }
            else
            {
                pi = (dynamic)3.1415926535897932384626433832795028841971693993751d;
            }
            

            T angleRads = (angle / (dynamic)180) * pi;
            T sinus = angleRads - (dynamic)angleRads * angleRads * angleRads / CalculateFactoriel(3) +
                (dynamic)angleRads * angleRads * angleRads * angleRads * angleRads / CalculateFactoriel(5) -
                (dynamic)angleRads * angleRads * angleRads * angleRads * angleRads * angleRads * angleRads / CalculateFactoriel(7);

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
