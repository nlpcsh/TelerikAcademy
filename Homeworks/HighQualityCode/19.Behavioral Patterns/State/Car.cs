namespace State
{
    using State.States;

    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Car
    {
        public const decimal InitialCarPrice = 30000m;
        public readonly int ThisYear = System.DateTime.Now.Year;

        public Car(string brand)
        {
            this.Brand = brand;
            this.State = new BrandNew(this);
            this.Price = InitialCarPrice;
        }

        public string Brand { get; set; }

        public State State { get; set; }

        public int YearOfProduction { get; set; }

        public decimal Price { get; set; }

        public void UpdateYear(int year)
        {
            this.State.UpdateYear(year);
        }

        public void Details()
        {
            System.Console.WriteLine(new string('-', 30));
            System.Console.WriteLine(" This car is: {0}", this.Brand);
            System.Console.WriteLine(" Year of production: {0}", this.YearOfProduction);
            System.Console.WriteLine(" In condition: {0}", this.State.GetType().Name);
            System.Console.WriteLine(" Price: {0}", InitialCarPrice * this.State.AgeToPriceCoefficien);
        }
    }
}