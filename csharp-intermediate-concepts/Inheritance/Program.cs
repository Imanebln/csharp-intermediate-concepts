using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // if we create an object of type XMLWriter, we will be able to access
            // its own method and the method from the base class

            XMLWriter xmlWriter = new XMLWriter("xmlFileName");
            xmlWriter.FormatXMLFile();
            xmlWriter.Write();
            Console.WriteLine(xmlWriter.FileName);

            JSONWriter jsonWriter = new JSONWriter("jsonFileName");
            jsonWriter.FormatJSONFile();
            jsonWriter.Write();
            Console.WriteLine(jsonWriter.FileName);

            //We can’t assign a higher rank object to a lower rank object => 
            //we can solve this problem by using the “as” keyword

            XMLWriter xml = new XMLWriter("any name");
            Writer writer = xml; //writer points to xml

            XMLWriter newWriter = writer as XMLWriter; //this is ok now because writer was xml
            newWriter.FormatXMLFile();
        }
    }
}
