namespace CompositePattern
{
    public abstract class Employee
    {
        protected Employee(string name)
        {
            this.Name = name;
        }

        protected string Name { get; private set; }

        public abstract void Add(Employee listToManage);

        public abstract void Remove(Employee listToManage);

        public abstract void Display(int depth);
    }
}