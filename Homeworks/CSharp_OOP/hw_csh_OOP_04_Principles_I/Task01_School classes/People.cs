namespace Task01_School_classes
{
    using System;

    class People
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("People name must be at least 2 symbols long");
                }
                this.name = value;
            }
        }
        
    }
}
