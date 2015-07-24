namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal abstract class Course
    {
        private string name = null;
        private IList<string> students = null;

        public Course(string name, string teacher, IList<string> students)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name is null or empty!");
                }

                this.name = value;
            }
        }

        public string Teacher { get; set; }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value ?? new List<string>();
            }
        }

        protected string ToStringHelper(params KeyValuePair<string, string>[] otherInfo)
        {
            Dictionary<string, string> info = new Dictionary<string, string>();

            info["Name"] = this.Name;
            info["Teacher"] = this.Teacher;
            info["Students"] = this.StudentsToString();

            foreach (var item in otherInfo)
            {
                info[item.Key] = item.Value;
            }

            string infoToString = string.Join("; ",
                                  info.Where(item => !string.IsNullOrEmpty(item.Value))
                                  .Select(item => item.Key + "=" + item.Value));

            return string.Format("{0} {{ {1} }}", this.GetType().Name, infoToString);
        }

        private string StudentsToString()
        {
            if (this.Students.Count == 0)
            {
                return "{ }";
            }

            return string.Format("{{ {0} }}", string.Join(", ", this.Students));
        }
    }
}