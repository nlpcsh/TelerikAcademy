namespace State.States
{
    using System;

    public class BrandNew : State
    {
        public BrandNew(Car car)
            : base(car)
        {
            this.Car.YearOfProduction = Car.ThisYear;
            this.AgeToPriceCoefficien = 1;
        }

        public override void UpdateYear(int year)
        {
            this.Car.YearOfProduction = year;

            if (this.Car.YearOfProduction < (Car.ThisYear - 5))
            {
                this.Car.State = new Older(this.Car);
            }

            if (((Car.ThisYear - 1) > this.Car.YearOfProduction) &&
                (this.Car.YearOfProduction >= (Car.ThisYear - 5)))
            {
                this.Car.State = new FiveYearsUsed(this.Car);
            }
        }
    }
}
