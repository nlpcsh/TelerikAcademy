using System;
using System.Collections.Generic;
using System.Linq;

namespace HW01_Define_a_Class
{
    using System.Text;
    using System.Threading.Tasks;

    class Battery
    {

        private BatteryType model = BatteryType.LiIon ;
        private double hoursIdle;
        private double hoursTalk;

        public BatteryType Model
        {
            get { return model; }

            set { this.Model = value; }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentException("The cell phone HoursIdle is less than 0!");
                }

                this.hoursIdle = value;
            }
        }
        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentException("The cell phone HoursTalk is less than 0!");
                }

                this.hoursTalk = value;
            }
        }

        public Battery(BatteryType model)
        {
            this.Model = model;
        }

        public Battery(BatteryType model, double HoursIdle, double HoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

    }
}
