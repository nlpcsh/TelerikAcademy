
namespace HW01_Define_a_Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Display
    {
        private double size;
        private int nbColors;

        public double Size
        {
            get { return this.size; }
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("The cell phone size is negative or zero!");
                }

                this.size = value;
            }
        }
        public int NbColors
        {
            get { return this.nbColors; }
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("The cell phone size is negative or zero!");
                }

                this.nbColors = value;
            }
        }

        public Display()
        {
            ;
        }

        public Display(double size, int nbColors)
        {
            this.Size = size;
            this.NbColors = nbColors;
        }
    }
}
