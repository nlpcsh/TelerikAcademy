namespace Task_3.ConsoleApplication1
{
    using System.Numerics;

    public class ConsoleApplication1
    {
        public static void Main()
        {
            string inputString = System.Console.ReadLine();
            BigInteger productOfTen = 1;
            BigInteger productOfOthers = 1;
            short counterOfNumbers = 0;
            bool hasTenNumbers = false;

            while (inputString != "END")
            {
                if (counterOfNumbers % 2 == 1)
                {
                    BigInteger product = 1;

                    foreach (char digit in inputString)
                    {
                        if (digit - '0' != 0)
                        {
                            product *= digit - '0';
                        }
                    }

                    if (hasTenNumbers)
                    {
                        productOfOthers *= product;
                    }
                    else
                    {
                        productOfTen *= product;
                    }
                }

                counterOfNumbers++;

                if (counterOfNumbers == 10)
                {
                    hasTenNumbers = true;
                }

                inputString = System.Console.ReadLine();
            }

            if (hasTenNumbers)
            {
                System.Console.WriteLine(productOfTen);
                System.Console.WriteLine(productOfOthers);
            }
            else
            {
                System.Console.WriteLine(productOfTen);
            }
        }
    }
}
