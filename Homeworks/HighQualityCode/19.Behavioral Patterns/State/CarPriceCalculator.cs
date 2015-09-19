namespace State
{
    public class CarPriceCalculator
    {
        public static void Main(string[] args)
        {
            var myCar = new Car("Mini");

            myCar.Details();
       
            myCar.UpdateYear(2014);
            myCar.Details();

            myCar.UpdateYear(2012);
            myCar.Details();

            myCar.UpdateYear(1999);
            myCar.Details();

            myCar.UpdateYear(2015);
            myCar.Details();
        }
    }
}
