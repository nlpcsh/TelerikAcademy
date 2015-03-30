/* Problem 1. Student class

Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone, e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task01_Student_class
{
    class RunProgram
    {
        static void Main()
        {
            Student firstStudent = new Student();
            firstStudent.FirstName = "Stamat";
            firstStudent.LastName = "Ivanov";
            Console.WriteLine(firstStudent); // called firstStudent.ToString()

            Student secondStudent = new Student();
            if (firstStudent != secondStudent)  // it is true
            {
                Console.WriteLine("{0} != {1}", firstStudent, secondStudent);
            }
                
            secondStudent.FirstName = "Stamat";
            secondStudent.LastName = "Ivanov";

            if (firstStudent == secondStudent)  // it is true
            {
                Console.WriteLine("{0} == {1}", firstStudent, secondStudent);
            }

            secondStudent.FirstName = "Minko";
            if (firstStudent != secondStudent)  // it is true
            {
                Console.WriteLine("{0} != {1}", firstStudent, secondStudent);
            }
        }
    }
}
