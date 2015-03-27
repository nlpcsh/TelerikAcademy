
namespace Task03_Animal_hierarchy
{
    using System;

    class Dog : Animal
    {
        private string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public override char Sex { get; set; }
        
        public Dog(string name, char sex, int age, string breed) : base(name, sex, age)
        {
            this.Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine(" Waf, waf! ");
        }
    }
}
