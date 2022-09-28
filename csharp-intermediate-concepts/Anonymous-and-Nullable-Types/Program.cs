using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_and_Nullable_Types
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAnonymousObj = new { Name = "Imane", Age = 23 };

            Console.WriteLine($"The name of myAnonymousObject is {myAnonymousObj.Name}, the age is {myAnonymousObj.Age}");

            int? number = null;
            number = 234;//comment this line to print out another result

            // The nullable types expose a few properties which can come in handy while working on our projects.
            // The HasValue property indicates whether a nullable type contains a value or it is a null.
            // The Value property enables us to retrieve the value of the nullable type if it is not null:

            if (number.HasValue)
            {
                Console.WriteLine(number.Value);
            }
            else
            {
                Console.WriteLine("number is null");
            }
        }
    }
}
