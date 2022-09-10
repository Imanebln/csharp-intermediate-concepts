using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {

        static void Main(string[] args)
        {
            CollectionInitializer<int> initializer = new CollectionInitializer<int>(5);

            initializer.AddElementsToCollection(5,8,12,74,23);

            int[] collection = initializer.RetrieveAllElements();

            int number = initializer.RetrieveElementOIndex(3);

            foreach(int element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine($"Element on the selected index is: {number}"); 

        }

        // Generic Methods
        public void ExampleMethod<T>(T param1, T param2)
        {
            //Methods body
        }
        // We must pay attention to the type parameter identifier if our generic method exists inside a generic class. If that class has a type T then, our method needs to have a different type (U, Y, R…). Otherwise, the type T from a method will hide the type T from a class.
    }
}
