using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    public abstract class AbstractionExampleClass
    {
        public void PrintToConsole(string text)
        {
            Console.WriteLine(text);
        }

        // An abstract method doesn’t contain implementation just a definition with the abstract keyword:
        public abstract void Print(string text);
    }

    class Program : AbstractionExampleClass
    {
        // To implement an abstract method in the class that derives from an abstract class, we need to use the override keyword:
        public override void Print(string text)
        {
            //method implementation
            Console.WriteLine("Method implemented successfully!");
        }
        static void Main(string[] args)
        {
            // The only purpose of the abstract class is to be inherited from and it cannot be instantiated:
            AbstractionExampleClass example = new AbstractionExampleClass();
            // Cannot create instance of this abstract class 

            
         
        }
    }

    // Sealed Classes
    // If we want to prevent our class to be inherited from, we need to use the sealed keyword.If anyone tries to use a sealed class as a base class, the compiler will throw an error
    public sealed class SealedClass
    {

    }
}
