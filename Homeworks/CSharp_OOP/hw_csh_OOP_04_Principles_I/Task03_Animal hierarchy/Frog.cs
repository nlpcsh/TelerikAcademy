
namespace Task03_Animal_hierarchy
{
    using System;

    class Frog : Animal
    {
        public override char Sex { get; set; }

        public Frog(string name, int age) : base(name, age)
        {
            ;
        }

        public Frog(string name, char sex, int age) : base(name, sex, age)
        {
            ;
        }

        public override void MakeSound()
        {
            Console.WriteLine(" Quack, quack! ");
        }
    }
}
