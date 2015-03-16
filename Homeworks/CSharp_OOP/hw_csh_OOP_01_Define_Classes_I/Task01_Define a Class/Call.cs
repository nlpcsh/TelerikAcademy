
namespace HW01_Define_a_Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Call
    {
        private DateTime date;
        private DateTime dialedPhonetime;
        private string dialedPhone;
        private string number;
        private double duration;

        public Call()
            : this(DateTime.MinValue, DateTime.MinValue, string.Empty, string.Empty, 0)
        {
            ;
        }

        public Call(DateTime date, DateTime time, string dialedPhone, string number, double duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhone = dialedPhone;
            this.Number = number;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }

        public DateTime Time
        {
            get { return this.dialedPhonetime; }
            set { this.dialedPhonetime = value; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set { this.dialedPhone = value; }
        }

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public double Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }

        public void CallInfo()
        {
            Console.WriteLine(" Call was performed at: {0} ", Date);
            Console.WriteLine(" From Number     {0} ", Number);
            Console.WriteLine(" To Number       {0} ", DialedPhone);
            Console.WriteLine(" Duration [min]: {0} ", Duration);
            Console.WriteLine();
        }

    }
}
