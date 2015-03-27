
namespace Task03_Animal_hierarchy
{
    using System;

    class Kitten : Cat
    {
        public override char Sex
        {
            get
            {
                return 'F';
            }
            set
            {
                Console.WriteLine("Gender of 'Kitten' can't be changed");
            }
        }

        public Kitten(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public Kitten(string name, int age, string breed) : this(name, age)
        {
            this.Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine(" Mrrr, mrrr! ");
        }
    }
}
