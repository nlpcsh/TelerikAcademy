namespace ChainOfResponsibility
{
    internal abstract class Robot
    {
        protected Robot Successor { get; set; }

        public void SetSuccessor(Robot successor)
        {
            this.Successor = successor;
        }

        public abstract void ProcessRequest(Component component);
    }
}
