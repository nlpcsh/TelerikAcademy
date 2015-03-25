
namespace StudentGroups
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<float> Marks { get; set; }

        private int groupNumber;

        public int GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }

        public Student(string firstName, string lastName, string fn, string tel, string email, int groupNumber, params float[] inputMarks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = new List<float>(inputMarks);
            this.GroupNumber = groupNumber;
        }
    }
}
