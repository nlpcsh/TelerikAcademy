/* Task 7 - Using delegates write a class Timer that can execute certain method at each t seconds.
 */

namespace Task07_Timer
{
    using System;
    using System.Threading;

    public delegate void TimeDelay(int seconds);

    class Timer
    {
        static void DoSomething(int seconds)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I was called by a delegate.");
                Console.WriteLine("I got parameter: {0}.", seconds);
                Thread.Sleep(seconds * 1000);
            }
        }

        static void Main()
        {
            TimeDelay td = new TimeDelay(DoSomething);
            td(1);
        }
    }
}
