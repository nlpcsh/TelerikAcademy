namespace VariablesDataExpressions
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get 
            { 
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get 
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size size, double angleOfRotation)
        {
            double width = (Math.Abs(Math.Cos(angleOfRotation)) * size.Width) +
                           (Math.Abs(Math.Sin(angleOfRotation)) * size.Height);

            double height = (Math.Abs(Math.Sin(angleOfRotation)) * size.Width) +
                            (Math.Abs(Math.Cos(angleOfRotation)) * size.Height);

            Size sizeAfterRotation = new Size(width, height);

            return sizeAfterRotation;
        }
    }
}
