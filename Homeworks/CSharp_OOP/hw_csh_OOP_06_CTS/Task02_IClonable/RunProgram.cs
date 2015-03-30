/* Problem 2. IClonable

Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
 */

namespace Task02_IClonable
{
    using System;
    using Task01_Student_class;

    class RunProgram
    {
        static void Main()
        {
            var someStudent = new Student() { 
                FirstName = "Penko", LastName = "Shamatov", MiddleName = "Mamaligarov",
                SSN = 77777777, 
                Address = "U-levo str, 108, Moon", 
                University = Universities.VSU, 
                Faculty = Faculties.BGFiology, 
                Specialty = Specialties.Physics, 
                Course = "Deep Space", 
                Email = "pri_kaka@moon.sp", 
                PhoneNumber = "800800800" };
            
            Student cloneStudent = someStudent.Clone() as Student;

            // Check if deep copy works...
            cloneStudent.FirstName = "Venko";
            cloneStudent.MiddleName = "K.";
            cloneStudent.LastName = "Malinkov";
            cloneStudent.SSN = 22222222;

            Console.WriteLine(someStudent.ToString());
            Console.WriteLine(cloneStudent.ToString());
        }
    }
}
