namespace Task01_School_classes
{
    using System.Collections.Generic;
    using Task01_School_classes.Interfaces;

    class Student : People, IComments 
    {
        private int classNumber;
        private List<string> comment;

        public List<string> Comments
        {
            get { return comment; }
            set { comment = value; }
        }
        public int ClassNumber
        {
            get { return classNumber; }
            set { classNumber = value; }
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
