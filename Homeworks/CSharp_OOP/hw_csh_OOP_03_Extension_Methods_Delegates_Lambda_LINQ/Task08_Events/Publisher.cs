
namespace Task08_Events
{
    using System;

    // A delegate type for hooking up change notifications.
    public delegate void ChangedEventHandler(object sender, EventArgs e);

    // A class to publish the event
    public class Publisher
    {
        // An event that clients can use to be notified whenever a method is called
        public event ChangedEventHandler Changed; // EventHandler

        public void DoSomething(string something)
        {
            Console.WriteLine(" Somebody {0}! ", something);
            this.OnChanged();
        }

        // Invoke the Changed event; called whenever list changes
        private void OnChanged()
        {
            if (this.Changed != null)
            {
                this.Changed(this, EventArgs.Empty);
            }
        }
    }
}
