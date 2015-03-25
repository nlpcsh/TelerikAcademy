/* Task 3 - Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
   Use LINQ query operators.
*/
using System;
using System.Linq;

namespace Task03_First_Berore_Last
{
    class SortFirstBeforeLast
    {
        static void Main()
        {
            var arrayStudents = new[] 
            { 
                new { firstName = "Borko", secondName = "Peshev" },
                new { firstName = "Simo", secondName = "Bobev" },
                new { firstName = "Misho", secondName = "Angelov" },
                new { firstName = "Atanas", secondName = "Vankov" }
            };

            var selectionArray = arrayStudents.Where(x => x.firstName[0] < x.secondName[0]);

            foreach (var item in selectionArray)
            {
                Console.WriteLine(item.firstName + " " + item.secondName);
            }
        }
    }
}
