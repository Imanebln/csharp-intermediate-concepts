using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class JSONWriter: Writer
    {
        public JSONWriter(string fileName)
        : base(fileName)
        {
        }
        public void FormatJSONFile()
        {
            Console.WriteLine("Formating JSON file");
        }
    }
}
