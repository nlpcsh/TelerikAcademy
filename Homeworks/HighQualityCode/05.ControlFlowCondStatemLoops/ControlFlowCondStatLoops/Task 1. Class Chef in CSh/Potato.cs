namespace ControlFlowCondStatLoops
{
    public class Potato : Vegetable
    {
        private bool isPeeled = false;
        private bool isRotten = false;

        public bool IsPeeled
        {
            get { return this.isPeeled; }
            set { this.isPeeled = value; }
        }

        public bool IsRotten
        {
            get { return this.isRotten; }
            set { this.isRotten = value; }
        }
    }
}
