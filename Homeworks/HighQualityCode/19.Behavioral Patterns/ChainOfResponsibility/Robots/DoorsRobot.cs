namespace ChainOfResponsibility.Robots
{
    internal class DoorsRobot : Robot
    {
        public override void ProcessRequest(Component component)
        {
            if (component.Name == "doors")
            {
                System.Console.WriteLine(
                    "{0} installed component '{1}'",
                    this.GetType().Name,
                    component.Name);
            }
            else
            {
                System.Console.WriteLine(
                    "Component '{0}' requires other type of robot!",
                    component.Name);
            }
        }
    }
}
