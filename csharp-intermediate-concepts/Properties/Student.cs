using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        public string Description { get; set; }//Auto-Implemented Property

        private string _name;
        private string _lastName;
        private int _age;

        //When we use an accessor overriding inside the property, we must pay attention to the following rules:

        /*We can change the accessibility level of only one accessor.There is no point in having both accessors modified. If we want to modify both accessors, we should just modify the property access level.*/

       /* We can’t use access modifier on the get or set blocks that are less restrictive of the access modifier applied on a property itself.So, if our property is private, there is no point in having the public get or set block.*/

        public int Age
        {
            get { return _age; }
            private set { _age = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public Student(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }
        public string GetFullName()
        {
            return _name + ' ' + _lastName;
        }
    }
}
