namespace ChainOfResponsibility
{
    using Robots;

    public class CarAssembler
    {
        static void Main(string[] args)
        {
            Robot manager = new RobotManager();
            Robot suspensionMechanic = new SuspensionRobot();
            Robot doorMechanic = new DoorsRobot();

            manager.SetSuccessor(suspensionMechanic);
            suspensionMechanic.SetSuccessor(doorMechanic);

            var doors = new Component("doors", 4);
            manager.ProcessRequest(doors);

            var computer = new Component("computer", 1);
            manager.ProcessRequest(computer);

            var suspension = new Component("shocks", 4);
            manager.ProcessRequest(suspension);

            var windows = new Component("windows", 8);
            manager.ProcessRequest(windows);
        }
    }
}
