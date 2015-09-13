namespace SimpleFactory
{
    public class Tea
    {
        public Tea(int milk, int coffee)
        {
            this.MilkContent = milk;
            this.TeaContent = coffee;
        }

        public int MilkContent { get; private set; }

        public int TeaContent { get; private set; }
    }
}
