namespace CompositePattern
{
    using System;
    using System.Collections.Generic;

    internal class Manager : Employee
    {
        private readonly ICollection<Employee> toManageList;

        public Manager(string name)
            : base(name)
        {
            this.toManageList = new List<Employee>();
        }

        public override void Add(Employee worker)
        {
            this.toManageList.Add(worker);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);

            foreach (var person in this.toManageList)
            {
                person.Display(depth + 3);
            }
        }

        public override void Remove(Employee worker)
        {
            this.toManageList.Remove(worker);
        }
    }
}