/* Problem 2. Students and workers

Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
 */

namespace Task02_Students_And_Workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RunProgram
    {
        public static Random rnd = new Random();

        static void Main()
        {
            var firstNameList = new List<string>() { "Ivan", "Toshko", "Stamat", "Penka", "Anka", "Venko", "Stanka", "Pesho", "Tzura", "Ginka" };

            var lastNameList = new List<string>() { "Ivanov", "Angelova", "Petrov", "Minkova", "Stankova", "Chervenkov", "Peshev", "Muskatova", "Grigorov", "Jendova" };

            var studentsList = new List<Student>();
            var workersList = new List<Worker>();

            // generate 10 students and workers
            for (int i = 0; i < 10; i++)
            {
                studentsList.Add(DefineStudent(firstNameList, lastNameList));
                workersList.Add(DefineWorker(firstNameList, lastNameList));
            }

            // sort the students by grade
            var sortedStudents =
                from students in studentsList
                orderby students.Grade
                select students;

            Console.WriteLine(" Sorted by grade students: \n");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(" {0,10}  {1,10}  has grade: {2,3}", student.FirstName, student.LastName, student.Grade);
            }

            Console.WriteLine();

            // sort the workers by money/hour:
            var sortedWokers =
                from workers in workersList
                orderby workers.MoneyPerHour()
                select workers;

            Console.WriteLine(" Sorted by money/hour workers: \n");
            foreach (var worker in sortedWokers)
            {
                Console.WriteLine(" {0,10}  {1,10}  earns: {2,7:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            // Merge and sort lists of students and workers
            var mergedList = sortedStudents.Concat<Human>(sortedWokers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var person in mergedList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }

        private static Student DefineStudent(List<string> firstNames, List<string> lastNames)
        {
            string fName = firstNames[rnd.Next(firstNames.Count)];
            string lName = lastNames[rnd.Next(lastNames.Count)];
            int grade = rnd.Next(2, 7);

            Student somebody = new Student(fName, lName, grade);

            return somebody;
        }

        private static Worker DefineWorker(List<string> firstNames, List<string> lastNames)
        {
            string fName = firstNames[rnd.Next(firstNames.Count)];
            string lName = lastNames[rnd.Next(lastNames.Count)];
            decimal hoursPerDay = rnd.Next(1, 8);
            decimal weekSalary = rnd.Next(500, 1000);

            Worker somebody = new Worker(fName, lName, hoursPerDay, weekSalary);

            return somebody;
        }


    }
}
