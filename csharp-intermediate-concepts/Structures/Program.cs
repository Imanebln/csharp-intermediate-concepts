using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time(3, 30, 25);
            time.PrintTime();

            Console.ReadKey();
        }
    }
    public struct Time
    {
        // The consumer can assign values to the properties by calling the constructor method but after that those properties need to stay immutable.

        private int _hours, _minutes, _seconds;

        public Time(int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }

        public void PrintTime()
        {
            Console.WriteLine($"Hours: {_hours}, Minutes: {_minutes}, Seconds: {_seconds}");
        }
    }
}
