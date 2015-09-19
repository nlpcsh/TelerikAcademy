namespace Strategy
{
    public class DishWasher
    {
        private readonly ILogger logger;

        public DishWasher(ILogger logger)
        {
            this.logger = logger;
        }

        public void WashDishes()
        {
            this.logger.Log("Starting to wash...");
            this.logger.Log("Washing...");
            this.logger.Log("Done.");
        }
    }
}
