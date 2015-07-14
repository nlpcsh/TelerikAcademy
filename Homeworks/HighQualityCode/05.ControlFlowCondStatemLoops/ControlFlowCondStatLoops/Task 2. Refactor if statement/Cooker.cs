namespace ControlFlowCondStatLoops
{
    internal class Cooker
    {
        public static void Main(string[] args)
        {
            Potato potato = new Potato();
            Chef currentChef = new Chef();

            ////... 
            if (potato != null)
            {
                if (!(potato.IsPeeled && potato.IsRotten))
                {
                    currentChef.Cook(potato);
                }
            }
        }
    }
}
