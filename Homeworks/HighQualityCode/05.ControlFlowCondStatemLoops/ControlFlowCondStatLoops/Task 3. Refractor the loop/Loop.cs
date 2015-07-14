namespace Task_3.Refractor_the_loop
{
    using System;

    internal class Loop
    {
        internal static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3 };
            int expectedValue = 3; 
            bool isFound = false;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        isFound = true;
                        break;
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }

            //// More code here
        }
    }
}
