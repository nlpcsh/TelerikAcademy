/* Problem 4. Person class

Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
Write a program to test this functionality.
 */

namespace Task04_Person_class
{
    using System;

    class RunProgram
    {
        static void Main()
        {
            var aPerson = new Person { Name = "Pepi" };
            Console.WriteLine(aPerson.ToString());

            var secondPerson = new Person { Name = "Minko", Age = 9 };
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
