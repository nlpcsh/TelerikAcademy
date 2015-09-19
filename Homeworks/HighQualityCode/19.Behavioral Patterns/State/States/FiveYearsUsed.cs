namespace State.States
{
    using System;

    public class FiveYearsUsed : State
    {
        public FiveYearsUsed(Car car)
            : base(car)
        {
            this.AgeToPriceCoefficien = 0.5m;
        }

        public override void UpdateYear(int year)
        {
            this.Car.YearOfProduction = year;

            if (this.Car.YearOfProduction < (Car.ThisYear - 5))
            {
                this.Car.State = new Older(this.Car);
            }

            if (this.Car.YearOfProduction > (Car.ThisYear - 1))
            {
                this.Car.State = new BrandNew(this.Car);
            }
        }
    }
}
