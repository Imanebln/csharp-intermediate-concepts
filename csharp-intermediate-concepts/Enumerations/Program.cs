using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public class Program
    {
        static void Main(string[] args)
        {
            DaysInWeek monday = DaysInWeek.Monday;

            Console.WriteLine(monday); // It is going to print out Monday
            Console.WriteLine((int)monday); //prints out the 0
            Console.ReadKey();
        }
    }
    public enum DaysInWeek: short
    {
        Monday = 10,
        Tuesday = 20,
        Wednesday = 35,
        Thursday = 48,
        Friday = 74,
        Saturday = 12,
        Sunday = 154
    }
}
