/* Problem 3. IComparable

Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
 */

namespace Task03_IComparable
{
    using System;
    using Task01_Student_class;

    class RunProgram
    {
        static void Main()
        {
            var someStudent = new Student()
            {
                FirstName = "Penko",
                LastName = "Shamatov",
                MiddleName = "Mamaligarov",
                SSN = 77777777,
                Address = "U-levo str, 108, Moon",
                University = Universities.VSU,
                Faculty = Faculties.BGFiology,
                Specialty = Specialties.Physics,
                Course = "Deep Space",
                Email = "pri_kaka@moon.sp",
                PhoneNumber = "800800800"
            };

            Student cloneStudent = someStudent.Clone() as Student;

            Console.WriteLine(@" CompareTo() Returns:
                 
  A signed number indicating the relative values of this instance and value. 
            
  Return Value Description Less than zero This instance is less than value. 
            
  Zero This instance is equal to value. 
            
  Greater than zero This instance is greater than value.-or- value is null. " + "\n");

            Console.WriteLine(" Compare a student and his clone: ");
            Console.WriteLine(" Result is: {0} \n", cloneStudent.CompareTo(someStudent));

            cloneStudent.FirstName = "Venko";
            cloneStudent.MiddleName = "K.";
            cloneStudent.LastName = "Malinkov";
            cloneStudent.SSN = 22222222;

            Console.WriteLine(" After changing the name and SSN:");
            Console.WriteLine(" Result is: {0}  \n", cloneStudent.CompareTo(someStudent));


        }
    }
}
