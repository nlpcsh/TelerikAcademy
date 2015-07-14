namespace ControlFlowCondStatLoops
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();

            Bowl bowl = new Bowl();

            this.Peel(potato);

            this.Peel(carrot);

            bowl = this.GetBowl();

            this.Cut(potato);

            this.Cut(carrot);

            bowl.Add(carrot);

            bowl.Add(potato);
        }

        public void Cook(Potato potato)
        {
        }

        private Bowl GetBowl()
        {
            ////... 
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            ////...
            return new Carrot();
        }

        private void Cut(Vegetable potato)
        {
            ////...
        }

        private void Peel(Vegetable vegetable)
        {
            ////...
        }

        private Potato GetPotato()
        {
            ////...
            return new Potato();
        }
    }
}