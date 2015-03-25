/* Task 18 - Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
  Use LINQ.
 
  Task 19 - Rewrite the previous using extension methods.
 */

namespace Task18_Grouped_by_GroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentGroups;

    class GroupetByGrNumber
    {
        static void Main()
        {

            var listOfStudents = new List<Student> 
            {
                new Student("Pesho", "Atanassov", "123005", "02555-2345", "pripepi@abv.bg", 1, 2.0f, 5.5f, 3.5f, 2.0f),
                new Student("Misho", "Ivanov", "123006", "555-1145", "mishov@mail.de", 2, 6.0f, 5.5f, 4.5f, 3.5f),
                new Student("Gosho", "Popov", "262345", "555-2399", "popov23@abv.bg", 1, 3.5f, 6.0f, 4.5f, 5.0f),
                new Student("Mariika", "Jordanoff", "110005", "555-2225", "mimito@dir.ca", 2, 5.5f, 3.5f, 5.5f, 6.0f),
                new Student("Stanka", "Vuchkova", "127706", "02555-1115", "pripepi@mail.ru", 3, 6.0f, 3.5f, 2.0f, 2.0f)
            };


            // Task 18 - Grouped by GroupNumber
            var groupedStudents =
                from student in listOfStudents
                group student by student.GroupNumber
                    into groups
                    select new
                    {
                        Group = groups.Key,
                        Students = groups.ToList()
                    };

            Console.WriteLine(" Grouping using LINQ:");
            foreach (var item in groupedStudents)
            {
                Console.WriteLine("\n Group: {0} Students: ", item.Group);

                foreach (var i in item.Students)
                {
                    Console.WriteLine(i.FirstName+ " " + i.LastName);
                }
            }

            Console.WriteLine();


            // Task 19 - Grouped by GroupName extensions
            var groupedStudents2 = listOfStudents.GroupBy(x => x.GroupNumber, (groupNumber, students) => new { Group = groupNumber, Students = students });

            Console.WriteLine(" Grouping using extensions:");
            foreach (var item in groupedStudents2)
            {
                Console.WriteLine("\n Group: {0} Students:", item.Group);

                foreach (var i in item.Students)
                {
                    Console.WriteLine(i.FirstName + " " + i.LastName);
                }
            }
        }
    }
}
