using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class JsonWriter : FileBase, IWriter
    {
        public void WriteFile()
        {
            Console.WriteLine("Writing file in the JsonWritter class.");
        }
        public override void SetName()
        {
            Console.WriteLine("Setting name in the JsonWriter class.");
        }
    }
}
