/* Task 9 - Create a class Student with properties:
 
 *  FirstName
 *  LastName
 *  FN
 *  Tel
 *  Email
 *  Marks (a List)
 *  GroupNumber
 
   Create a List<Student> with sample students. Select only the students that are from group number 2.
   Use LINQ query. Order the students by FirstName.

 Task 10 - Implement the previous using the same query expressed with extension methods.
 
 Task 11 - Extract all students that have email in abv.bg.
   Use string methods and LINQ.
 
 Task 12 - Extract all students with phones in Sofia.
   Use LINQ.
 
 Task 13 - Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
   Use LINQ.
 
 Task 14 - Write down a similar program that extracts the students with exactly two marks "2".
   Use extension methods.
 
 Task 15 - Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
 
 Task 16 - Create a class Group with properties GroupNumber and DepartmentName.
   Introduce a property GroupNumber in the Student class.
   Extract all students from "Mathematics" department.
   Use the Join operator.
  */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StudentGroups
{
    class StudentTest
    {
        static void Main()
        {

            // Task 9 - Students groups
            var listOfStudents = new List<Student> 
            {
                new Student("Pesho", "Atanassov", "123005", "02555-2345", "pripepi@abv.bg", 1, 2.0f, 5.5f, 3.5f, 2.0f),
                new Student("Misho", "Ivanov", "123006", "555-1145", "mishov@mail.de", 2, 6.0f, 5.5f, 4.5f, 3.5f),
                new Student("Gosho", "Popov", "262345", "555-2399", "popov23@abv.bg", 1, 3.5f, 6.0f, 4.5f, 5.0f),
                new Student("Mariika", "Jordanoff", "110005", "555-2225", "mimito@dir.ca", 2, 5.5f, 3.5f, 5.5f, 6.0f),
                new Student("Stanka", "Vuchkova", "127706", "02555-1115", "pripepi@mail.ru", 3, 6.0f, 3.5f, 2.0f, 2.0f)
            };

            var result =
                from students in listOfStudents
                where students.GroupNumber == 2
                orderby students.FirstName
                select students;

            Console.WriteLine(" Using LINQ - Students from group 2 are:");
            PrintFromList(result);


            // Task 10 - Student groups extensions
            Console.WriteLine();
            Console.WriteLine(" Using Lambda Expression: ");
            result = listOfStudents.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);
            PrintFromList(result);


            // Task 11 - Extract students by email
            Console.WriteLine();
            result =
                from students in listOfStudents
                where students.Email.Contains("@abv.bg")
                orderby students.FirstName
                select students;
            Console.WriteLine(" Using LINQ - Students using e-mails in ABV.BG are:");
            PrintFromList(result);


            // Task 12 - Extract students by phone
            Console.WriteLine();
            result =
                from students in listOfStudents
                where students.Tel.StartsWith("02")
                orderby students.FirstName
                select students;
            Console.WriteLine(" Using LINQ - Students with phones in Sofia are:");
            PrintFromList(result);


            // Task 13 - Extract students by marks
            Console.WriteLine();
            var resultExellent =
                from students in listOfStudents
                where students.Marks.Contains(6f)
                select new
                {
                    FullName = students.FirstName + " " + students.LastName,
                    MarksList = students.Marks
                };

            Console.WriteLine(" Using LINQ - Students having at least one '6' in the marks:");
            foreach (var item in resultExellent)
            {
                Console.WriteLine(" {0} {1} ", item.FullName, string.Join(", ", item.MarksList));
            }


            // Task 14 - Extract students with two marks
            Console.WriteLine();
            //var listWithTwoOf2 = new List<Student>();
            //foreach (var student in listOfStudents)
            //{
            //    int count = 0;
            //    foreach (var item in student.Marks)
            //    {
            //        if (item - 2f == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 2)
            //    {
            //        listWithTwoOf2.Add(student);
            //    }
            //}
            //PrintFromList(listWithTwoOf2);

            var listWithTwoOf2 = listOfStudents.Where(x => x.Marks.FindAll(y => y == 2).Count() == 2);
            Console.WriteLine(" Students with 2 marks of '2': ");
            PrintFromList(listWithTwoOf2);

            // Task 15 - Extract marks
            Console.WriteLine();

            var selection2006 = listOfStudents.Where(x => x.FN[4] == '0' && x.FN[5] == '6');
            Console.WriteLine(" Marks from 2006 are: ");
            foreach (var item in selection2006)
            {
                Console.WriteLine(" {0} has marks: {1} ",item.FirstName + " " + item.LastName, string.Join(", ", item.Marks));
            }

            // Task 16 - Groups
            Console.WriteLine();
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Physics"),
                new Group(2, "Mathematics"),
                new Group(3, "Maths"),
                new Group(4, "Computer Science"),
                new Group(5, "Medicine"),
                new Group(6, "Biology"),
            };

            var studentsFromMathematics = listOfStudents
                .Join(groups, st => st.GroupNumber, gr => gr.GroupNumber,
                (st, gr) => new
                {
                    Student = st,
                    Group = gr,
                })
                .Where(mat => mat.Group.DepartmentName == "Mathematics");

            Console.WriteLine(" Students from Mathematics faculty: ");
            foreach (var st in studentsFromMathematics)
            {
                Console.WriteLine(st.Student.FirstName + " " + st.Student.LastName);
            }

        }

        public static void PrintFromList(IEnumerable<Student> someList)
        {
            foreach (var item in someList)
            {
                Console.WriteLine(" {0} {1}", item.FirstName, item.LastName);
            }
        }
    }
}
