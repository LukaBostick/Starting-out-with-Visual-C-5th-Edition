using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Roster
{
    class Student
    {
        // Properties
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }

        // Constructor
        public Student(string last, string first)
        {
            LastName = last;
            FirstName = first;
        }
    }
}
