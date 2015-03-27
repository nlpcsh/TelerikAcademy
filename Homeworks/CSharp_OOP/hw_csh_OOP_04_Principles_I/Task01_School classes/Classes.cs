
namespace Task01_School_classes
{
    using System;
    using Task01_School_classes.Interfaces;
    using System.Collections.Generic;

    class Classes : IComments
    {
        private string id;
        private List<Teacher> teachers;
        private List<string> comment;

        public List<string> Comments
        {
            get { return comment; }
            set { comment = value; }
        }
        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }
        public string ID
        {
            get { return id; }
            private set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Classes ID must be at least 1 symbol long");
                }
                this.id = value;
            }
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
