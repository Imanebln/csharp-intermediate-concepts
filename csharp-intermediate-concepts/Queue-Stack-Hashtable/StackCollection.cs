using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_Hashtable
{
    public class StackCollection
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            Stack<int> stackInt = new Stack<int>();

            // Methods and Properties
            //The Push method inserts an object at the top of the collection:
            Stack stack1 = new Stack();
            stack1.Push(328);
            stack1.Push("Fifty Five");
            stack1.Push(124.80);

            foreach(var item in stack1)
            {
                Console.WriteLine(item);
            }

            //Pop removes the element which was included last in a collection and returns it:
            Stack stackCollection2 = new Stack();
            stackCollection2.Push(328);
            stackCollection2.Push("Fifty Five");
            stackCollection2.Push(124.87);

            double number = Convert.ToDouble(stackCollection2.Pop());
            Console.WriteLine($"Element removed from collection is: {number}");

            foreach(var item in stackCollection2)
            {
                Console.WriteLine(item);
            }

            //Peek returns an object ready to exit the collection, but it doesn’t remove it:
            Stack stackCollection3 = new Stack();
            stackCollection3.Push(328);
            stackCollection3.Push("Fifty Five");
            stackCollection3.Push(124.87);

            double number1 = Convert.ToDouble(stackCollection3.Peek());

            Console.WriteLine($"Element returned from a collection is: {number1}");
            foreach (var item in stackCollection3)
            {
                Console.WriteLine(item);
            }

            //To remove all objects from a collection, we use the Clear method.
            stackCollection2.Clear();

            //If we want to count the number of elements, we use the Count property:
            Console.WriteLine(stackCollection2.Count);


        }
    }
}
