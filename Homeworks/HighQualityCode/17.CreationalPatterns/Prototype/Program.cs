namespace Prototype
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var darkHelicopter = new Helicopter("Helicopter ", 180, 80);
            Console.WriteLine(darkHelicopter);

            // var anotherHelicopter = new Helicopter("Helicopter ", 180, 80);
            var anotherHelicopter = darkHelicopter.Clone();
            darkHelicopter.Speed = 200;
            Console.WriteLine(anotherHelicopter);
        }
    }
}