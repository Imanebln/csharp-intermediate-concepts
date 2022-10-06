using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class XMLWriter : Writer
    {
        public XMLWriter(string fileName)
       : base(fileName)
        {
        }

        public void FormatXMLFile()
        {
            Console.WriteLine("Formating XML file");
        }
        //The new keyword will simply tell the compiler that
        //we are hundred percent surein what we are doing and
        //that we don’t want a warning message to appear anymore
        public new void SetName()
        {
            Console.WriteLine("Setting name in the XMLWriter class");
        }

        //If we declare a method as a virtual in our base class,
        //we can create a method in a derived class with the keyword override
        //to declare another implementation of that method
        public override void CalculateFileSize()
        {
            //we can call an original implementation of that method
            //in a derived class by using the base keyword
            base.CalculateFileSize();

            Console.WriteLine("Calculating file size in the XMLWriter class");
        }
    }
}
