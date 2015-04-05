
namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;

        public decimal Length
        {
            get 
            {
                return this.length;
            }
            private set
            {
                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }

        public decimal Area
        {
            get { return length * width; }
        }

        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width) : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area);
        }
    }
}
