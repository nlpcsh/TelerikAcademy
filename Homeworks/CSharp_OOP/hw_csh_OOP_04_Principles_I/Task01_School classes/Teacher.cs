
namespace Task01_School_classes
{
    using System.Collections.Generic;
    using Task01_School_classes.Interfaces;

    class Teacher : People, IComments
    {
        private List<Discipline> course;
        private List<string> comment;

        public List<string> Comments
        {
            get { return comment; }
            set { comment = value; }
        }
        public List<Discipline> Course
        {
            get { return course; }
            set { course = value; }
        }
        
        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }

    }
}
