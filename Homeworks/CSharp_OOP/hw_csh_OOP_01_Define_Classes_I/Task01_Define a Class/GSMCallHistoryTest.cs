
namespace HW01_Define_a_Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class GSMCallHistoryTest
    {
        static Random rand = new Random();

        static void Main()
        {


            // Initial testing
            TestGSM testGsm = new TestGSM();
            testGsm.CreateFewGSMs();
            Console.WriteLine();
            Console.WriteLine(GSM.iPhone4S);

            Console.WriteLine();


            // Testing GSM class
            GSM certainGsm = new GSM("PadPhone", "Asus", 1000, "Me");

            certainGsm.DisplayGSMInfo();

            // create some calls
            List<Call> someCalls = new List<Call>();
            for (int i = 0; i < 10; i++)
            {
                someCalls.Add(new Call(DateTime.Now, DateTime.Now, "088888888", "070011111", rand.Next(15)));
            }

            // Add call to GSM statistics:
            for (int i = 0; i < someCalls.Count; i++)
            {
                certainGsm.AddToHistory(someCalls[i]);
                certainGsm.ViewHistory(i);
            }

            // calculate total price of the call
            double singleCallPrice = 0.37;
            decimal totalCallDuration = certainGsm.CalculatePriceOfCalls(singleCallPrice);
            Console.WriteLine(" Total price of all calls is: {0:F2} ", totalCallDuration);

            // Remove longest call
            double longestDuration = 0;
            int indexOfLongestCall = 0;
            for (int i = 0; i < someCalls.Count; i++)
            {
                if (someCalls[i].Duration >= longestDuration)
                {
                    longestDuration = someCalls[i].Duration;
                    indexOfLongestCall = i;
                }
            }

            certainGsm.RemoveHistory(someCalls[indexOfLongestCall]);

            // Recalculate the total price
            totalCallDuration = certainGsm.CalculatePriceOfCalls(singleCallPrice);
            Console.WriteLine(" Total price of all calls exept the longest is: {0:F2} ", totalCallDuration);

            // clear the history af calls and print it
            certainGsm.ClearCallHistory();

            if (someCalls.Count > 0)
            {
                Console.WriteLine(" No recent history! ");
            }
            else
            {
                for (int i = 0; i < someCalls.Count; i++)
                {
                    certainGsm.ViewHistory(i);
                }
            }
        }
    }
}
