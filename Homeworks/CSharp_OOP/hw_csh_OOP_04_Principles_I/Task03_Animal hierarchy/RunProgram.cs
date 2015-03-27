/* Problem 3. Animal hierarchy

Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
 */

namespace Task03_Animal_hierarchy
{
    using System;
    using System.Linq;

    class RunProgram
    {
        static void Main()
        {
            Animal[] animals =
            {
                new Dog("Rexa", 'F', 5, "Golden"),
                new Dog("Pesho",'M', 11, "Pekingese"),
                new Dog("Borko", 'M', 1, "Pomiqr"),
                new Dog("Max", 'M', 3, "Labrador"),

                new Tomcat("Tomi", 6, "Roshav"), 
                new Tomcat("Rijko", 4),

                new Kitten("Mimi", 2, "Siamska"),
                new Kitten("Duki", 1, "Persiiska"),

                new Frog("Froggica", 'F', 2),
                new Frog("Kermit", 'M', 1)
            };

            double averageDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double averageCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);
            double averageFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);

            Console.WriteLine("Average dogs' age is: {0}", averageDogsAge);
            Console.WriteLine("Average cats' age is: {0}", averageCatsAge);
            Console.WriteLine("Average frogs' age is: {0}", averageFrogsAge);

        }
    }
}
