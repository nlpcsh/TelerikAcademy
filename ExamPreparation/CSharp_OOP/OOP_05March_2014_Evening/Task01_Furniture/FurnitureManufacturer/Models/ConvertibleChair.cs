
namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private decimal initialHeight;
        private bool isConverted;

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
            private set
            {
                this.isConverted = value;
            }
        }

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.IsConverted = false;
            this.initialHeight = height;
        }

        public void Convert()
        {
            this.IsConverted = !isConverted;

            if (this.IsConverted)
            {
                this.Height = 0.10m;
            }
            else
            {
                this.Height = initialHeight;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
