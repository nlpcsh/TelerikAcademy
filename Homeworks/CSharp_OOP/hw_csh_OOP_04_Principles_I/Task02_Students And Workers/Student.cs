
namespace Task02_Students_And_Workers
{
    using System;

    class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string fName, string lName, int grade)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Grade = grade;
        }
        
    }
}
