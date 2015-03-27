
namespace Task01_School_classes
{
    using System;
    using System.Collections.Generic;
    using Task01_School_classes.Interfaces;

    class Discipline : IComments
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private List<string> comment;

        public List<string> Comments
        {
            get { return comment; }
            set { comment = value; }
        }
        public int NumberOfExercises
        {
            get { return numberOfExercises; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of excercises cannot be negative");
                }
                this.numberOfExercises = value;
            }
        }
        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be negative");
                }
                this.numberOfLectures = value;
            }
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Discipline name must be at least 2 symbols long");
                }
                this.name = value;
            }
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
