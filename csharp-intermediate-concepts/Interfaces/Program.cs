using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Referencing Classes Through Interfaces

            XmlWriter writer = new XmlWriter();
            writer.SetName(); //overridden method from a base class
            writer.WriteFile(); //method from an interface

            IWriter writer2 = new XmlWriter();
            writer2.WriteFile(); //method from an interface
            //writer2.SetName(); //error the SetName method is not part of the IWriter interface

            //If we use an interface to create an object,
            //we can access only those members declared in that interface.

            // Using an Interface to Decouple Classes
            XmlWriter xmlWriter = new XmlWriter();
            JsonWriter jsonWriter = new JsonWriter();

            FileWriter fileWriter = new FileWriter(xmlWriter);
            fileWriter.Write();

            fileWriter = new FileWriter(jsonWriter);
            fileWriter.Write();

            //Now we have one class that does its job for any class that inherits from the IWriter interface.
            //This feature is well known as a Dependency Injection.

            //Working with Multiple Interfaces
            //A class can inherit just from one base class, but it can implement multiple interfaces.
            //The class must implement all the methods defined in those interfaces



        }
    }
}
