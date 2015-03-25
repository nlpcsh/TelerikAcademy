using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGroups
{
    class Group
    {
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public Group(int grNb, string depName)
        {
            this.GroupNumber = grNb ;
            this.DepartmentName = depName;
        }
    }
}
