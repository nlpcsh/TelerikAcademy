
namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            protected set
            {
                this.numberOfLegs = value;
            }
        }

        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Legs: {0}", this.NumberOfLegs);
        }
    }
}
