namespace SimpleFactory
{
    using System;

    public static class TeaMaker
    {
        public static void Main()
        {
            var teaFactory = new TeaFactory();
            var milkedTea = teaFactory.GetTea(TeaType.Milked);
            var regularTea = teaFactory.GetTea(TeaType.Regular);
            Console.WriteLine("Milked Tea - Milk content: {0} ml, Tea content: {1} ml", milkedTea.MilkContent, milkedTea.TeaContent);
            Console.WriteLine("Regular tea - Milk content: {0} ml, Tea content: {1} ml", regularTea.MilkContent, regularTea.TeaContent);
        }
    }
}
