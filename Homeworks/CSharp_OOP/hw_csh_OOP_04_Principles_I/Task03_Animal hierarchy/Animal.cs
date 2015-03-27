
namespace Task03_Animal_hierarchy
{
    using System;
    using Task03_Animal_hierarchy.Interfaces;

    public abstract class Animal : ISound
    {

        private int age;
        private string name;

        public abstract char Sex { get; set; }
       
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                } 
                name = value;
            }
        }
       
        public int Age
        {
            get { return age; }
            set
            {
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                } 
                age = value;
            }
        }

        public Animal()
        {
            ;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Animal(string name, char sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public abstract void MakeSound();
 
    }
}
