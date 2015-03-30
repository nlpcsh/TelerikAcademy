﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01_Shapes
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width / 2;
        }
    }
}
