namespace Strategy
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine("[{0}] {1}", System.DateTime.Now.ToLongTimeString(), message);
        }
    }
}
