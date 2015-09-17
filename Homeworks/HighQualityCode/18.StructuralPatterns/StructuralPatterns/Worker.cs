namespace CompositePattern
{
    using System;

    internal class Worker : Employee
    {
        public Worker(string name)
            : base(name)
        {
        }

        public override void Add(Employee listToManage)
        {
            Console.WriteLine("Cannot manage other employees!");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);
        }

        public override void Remove(Employee listToManage)
        {
            Console.WriteLine("Cannot manage other employees!");
        }
    }
}