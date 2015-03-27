
namespace Task03_Animal_hierarchy
{
    using System;

    class Tomcat : Cat
    {

        public override char Sex
        {

            get
            {
                return 'M';
            }
            set { Console.WriteLine("Gender of 'Tomcat' can't be changed"); }
        }

        public Tomcat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Tomcat(string name, int age, string breed) : this(name, age)
        {
            this.Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine(" Phhh, pffff! ");
        }
    }
}
