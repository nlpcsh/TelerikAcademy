using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_Person_class
{
    class Person
    {
        private string name;
        private int? age = null;

        public int? Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format(" Name: {0} \n Age: N/A ", this.Name);
            }
            return string.Format(" Name: {0} \n Age: {1}", this.Name, this.Age);
        }
    }
}
