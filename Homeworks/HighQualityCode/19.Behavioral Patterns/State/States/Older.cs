namespace State.States
{
    using System;

    public class Older : State
    {
        public Older(Car car)
            : base(car)
        {
            this.AgeToPriceCoefficien = 0.15m;
        }

        public override void UpdateYear(int year)
        {
            this.Car.YearOfProduction = year;

            if (this.Car.YearOfProduction > (Car.ThisYear - 1))
            {
                this.Car.State = new BrandNew(this.Car);
            }

            if (((Car.ThisYear - 1) < this.Car.YearOfProduction) &&
                (this.Car.YearOfProduction >= (Car.ThisYear - 5)))
            {
                this.Car.State = new FiveYearsUsed(this.Car);
            }
        }
    }
}
