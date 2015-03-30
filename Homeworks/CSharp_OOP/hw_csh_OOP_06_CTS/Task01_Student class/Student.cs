
namespace Task01_Student_class
{
    using System;
    using System.Reflection;
    
    public enum Specialties
    {
        Mathematics, Physics, Literature 
    }

    public enum Universities
    {
        SU, TU, VSU
    }

    public enum Faculties
    {
        AppliedScience, ComputerScience, BGFiology
    }


    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private int ssn;
        private string address;
        private string phoneNumber;
        private string email;
        private string course;
        private Specialties specialty;
        private Universities university;
        private Faculties faculty;

        public Faculties Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        
        public Universities University
        {
            get { return university; }
            set { university = value; }
        }
        
        public Specialties Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
 
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        public int SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public override bool Equals(object param)
        {
            // If the cast is invalid, the result will be null
            Student student = param as Student;

            // Check if we have valid not null Student object
            if (student == null)
            {
                return false;
            }

            // Compare the reference type member fields
            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            // Compare the value type member fields
            if (this.LastName != student.LastName)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return   this.FirstName.GetHashCode()
                   ^ this.MiddleName.GetHashCode()
                   ^ this.LastName.GetHashCode()
                   ^ this.SSN.GetHashCode();
        }

        public override string ToString()
        {
            return " Student data: \n" + this.FirstName + " " + this.MiddleName + " " + this.LastName + "\n "
                + " SSN: " + this.SSN + "\n" 
                + " Address: " + this.Address + "\n "
                + " Phone: " + this.PhoneNumber + "\n " 
                + " e-mail: " + this.Email + "\n " 
                + " Course: " + this.Course + "\n"
                + " University: " + this.University + "\n"
                + " Faculty: " + this.Faculty + "\n"
                + " Specialty: " + this.Specialty + "\n";
        }

        // source of the code of Clone():
        //   http://www.c-sharpcorner.com/UploadFile/ff2f08/deep-copy-of-object-in-C-Sharp/
 
        public object Clone()
        {
            Student objSource = this;
            //step : 1 Get the type of source object and create a new instance of that type
            Type typeSource = objSource.GetType();
            object objTarget = Activator.CreateInstance(typeSource);

            //Step2 : Get all the properties of source object type
            PropertyInfo[] propertyInfo = typeSource.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            //Step : 3 Assign all source property to target object's properties
            foreach (PropertyInfo property in propertyInfo)
            {
                //Check whether property can be written to
                if (property.CanWrite)
                {
                    //Step : 4 check whether property type is value type, enum or string type
                    if (property.PropertyType.IsValueType || property.PropertyType.IsEnum || property.PropertyType.Equals(typeof(System.String)))
                    {
                        property.SetValue(objTarget, property.GetValue(objSource, null), null);
                    }
                    //else property type is object/complex types, so need to recursively call this method until the end of the tree is reached
                    else
                    {
                        object objPropertyValue = property.GetValue(objSource, null);
                        if (objPropertyValue == null)
                        {
                            property.SetValue(objTarget, null, null);
                        }
                        else
                        {
                            property.SetValue(objTarget, Clone(), null);
                        }
                    }
                }
            }
            return objTarget;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName == other.FirstName && this.MiddleName == other.MiddleName && this.LastName == other.LastName)
            {
                return this.SSN.CompareTo(other.SSN);
            }
            else
            {
                return (this.FirstName + this.MiddleName + this.LastName).CompareTo(other.FirstName + other.MiddleName + other.LastName);
            }
        }
    }
}
