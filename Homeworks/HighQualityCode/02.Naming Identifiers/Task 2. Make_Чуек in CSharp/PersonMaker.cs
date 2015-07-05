namespace Task_2.CreatePerson
{
    using System;

    internal class PersonMaker
    {
        public enum Gender 
        { 
            Male, 
            Female 
        }

        public void CreatePerson(int age)
        {
            Person person = new Person();
            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Sex = Gender.Male;
            }
            else
            {
                person.Name = "Мацето";
                person.Sex = Gender.Female;
            }
        }
        
        internal class Person
        {
            public Gender Sex { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
