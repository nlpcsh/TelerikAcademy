namespace ChainOfResponsibility.Robots
{
    internal class SuspensionRobot : Robot
    {
        public override void ProcessRequest(Component component)
        {
            if (component.Name == "shocks")
            {
                System.Console.WriteLine(
                    "{0} installed component '{1}'",
                    this.GetType().Name,
                    component.Name);
            }
            else if (this.Successor != null)
            {
                this.Successor.ProcessRequest(component);
            }
        }
    }
}
