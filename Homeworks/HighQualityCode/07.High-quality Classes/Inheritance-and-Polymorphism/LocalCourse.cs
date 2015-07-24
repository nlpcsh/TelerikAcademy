namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    internal class LocalCourse : Course
    {
        public LocalCourse(string name, string teacher = "", IList<string> students = null)
            : base(name, teacher, students)
        {
            return;
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            return this.ToStringHelper(new KeyValuePair<string, string>("Lab", this.Lab));
        }
    }
}