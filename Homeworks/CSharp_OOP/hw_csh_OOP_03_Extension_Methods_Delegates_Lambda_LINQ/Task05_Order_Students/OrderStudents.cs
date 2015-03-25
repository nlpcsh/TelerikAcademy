/* Task 5 - Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
  Rewrite the same with LINQ.
 */

namespace Task05_Order_Students
{
    using System;
    using System.Linq;

    class OrderStudents
    {
        static void Main()
        {
            var arrayStudents = new[] 
            { 
                new { firstName = "Borko", secondName = "Peshev" },
                new { firstName = "Borko", secondName = "Bobev" },
                new { firstName = "Misho", secondName = "Angelov" },
                new { firstName = "Atanas", secondName = "Vankov" }
            };

            // Lambda expression
            Console.WriteLine(" using Lambda expression: ");
            var selectionArray = arrayStudents.OrderByDescending(x => x.firstName).ThenByDescending(x => x.secondName);

            foreach (var item in selectionArray)
            {
                Console.WriteLine(item.firstName + " " + item.secondName);
            }

            Console.WriteLine();
            Console.WriteLine(" using LINQ: ");

            // LINQ
            selectionArray =
                from student in arrayStudents
                orderby student.firstName descending, student.secondName descending
                select student;

            foreach (var item in selectionArray)
            {
                Console.WriteLine(item.firstName + " " + item.secondName);
            }

        }
    }
}
