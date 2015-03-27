
namespace Task01_School_classes
{
    using System;
    using System.Collections.Generic;

    class School
    {
        private List<Teacher> teachers;
        private List<Discipline> disciplines;
        private List<Student> students;
        private List<Classes> classes;

        public List<Classes> Classess
        {
            get { return classes; }
            set { classes = value; }
        }
        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        public List<Discipline> Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }
        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }
        
    }
}
