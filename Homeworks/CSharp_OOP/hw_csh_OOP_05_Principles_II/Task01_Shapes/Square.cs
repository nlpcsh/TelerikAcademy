using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01_Shapes
{
    class Square : Shape
    {
        public Square(double width)
        {
            this.Height = width;
            this.Width = width;
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Width;
        }
    }
}
