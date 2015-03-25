/* Task 8 - Read in MSDN about the keyword event in C# and how to publish events.
    Re-implement the above using .NET events and following the best practices.
 */

namespace Task08_Events
{
    using System;

    class Events
    {
        static void Main()
        {
            var someInstance = new Publisher();

            // Attach method as a listener
            someInstance.Changed += ListOnChanged;
            Console.WriteLine(" The event is attached!");

            someInstance.DoSomething(" walks ");

            someInstance.DoSomething(" talks ");

            // Detach the event
            someInstance.Changed -= ListOnChanged;
            Console.WriteLine(" The event is detached!");

            someInstance.DoSomething(" jumps ");
        }

        private static void ListOnChanged(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("ListOnChanged(object sender, EventArgs eventArgs)");
            Console.WriteLine();
        }
    }
}
