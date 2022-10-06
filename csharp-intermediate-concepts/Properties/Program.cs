using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Imane", "Boulouane");
            string name = student.Name; //call to a get block of the Name property
            string lastName = student.LastName; // call to a get block of the LastName property
            student.Name = "Anas"; //call to a set block of the Name property
            student.LastName = "Chahid"; // call to a set block of the LastName property
        }
    }
}
