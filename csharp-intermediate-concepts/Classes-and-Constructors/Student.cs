using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Constructors
{
    partial class Student
    {
        private string FirstName;
        private string LastName;

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        
    }
    partial class Student
    {
        public Student(string name, string lastName)
        {
            FirstName = name;
            LastName = lastName;
        }
        public string GetFullName()
        {
            return FirstName + ' ' + LastName;
        }
    }
}
