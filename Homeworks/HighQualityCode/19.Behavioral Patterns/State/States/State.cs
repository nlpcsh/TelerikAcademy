namespace State.States
{
    public abstract class State
    {
        protected State(Car car)
        {
            this.Car = car;
        }

        public decimal AgeToPriceCoefficien { get; set; }

        protected Car Car { get; private set; }

        public abstract void UpdateYear(int year);
    }
}
