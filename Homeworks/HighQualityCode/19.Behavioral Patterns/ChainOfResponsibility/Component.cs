namespace ChainOfResponsibility
{
    /// <summary>
    /// Class holding request details
    /// </summary>
    internal class Component
    {
        public Component(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }

        public string Name { get; set; }

        public int Quantity { get; set; }
    }
}
