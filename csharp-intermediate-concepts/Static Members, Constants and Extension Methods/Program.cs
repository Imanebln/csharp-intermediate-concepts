using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members__Constants_and_Extension_Methods
{
    //The static class can contain only the static members.
    //Its purpose is to act as a holder for the utility methods and fields. 
    public static class TestClass
    {
        private static int number;

        static TestClass()
        {
            number = 54;
        }
    }
    public class Program
    {
        //Creating a Field by Using the Const Keyword
        public const int constNumber = 15;
        static void Main(string[] args)
        {
            string word = "football".FirstLetterUpperCase();

            Console.WriteLine(word.GetType()); //string type
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
