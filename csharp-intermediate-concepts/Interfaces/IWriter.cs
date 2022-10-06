using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IWriter
    {
        void WriteFile();
    }
    //after our classes inherit from an interface,
    //they must implement the member WriteFile().
    //Otherwise, we would get a compiler error.




}
