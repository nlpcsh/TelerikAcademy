/* Task 4 - Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
 */

namespace Task04_Age_Range
{
    using System;
    using System.Linq;

    class AgeRange
    {
        static void Main()
        {
            var arrayStudents = new[] 
            { 
                new { firstName = "Borko", secondName = "Peshev", age = 20 },
                new { firstName = "Simo", secondName = "Bobev", age = 17 },
                new { firstName = "Misho", secondName = "Angelov", age = 29 },
                new { firstName = "Atanas", secondName = "Vankov", age = 23 }
            };

            var selectionArray = arrayStudents.Where(x => (x.age <= 24 && x.age >= 18));

            foreach (var item in selectionArray)
            {
                Console.WriteLine(item.firstName + " " + item.secondName);
            }
        }
    }
}
