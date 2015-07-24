namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    internal class OffsiteCourse : Course
    {
        public OffsiteCourse(string name, string teacher = "", IList<string> students = null)
            : base(name, teacher, students)
        {
            return;
        }

        public string Town { get; set; }

        public override string ToString()
        {
            return this.ToStringHelper(new KeyValuePair<string, string>("Town", this.Town));
        }
    }
}