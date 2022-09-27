/*using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_Hashtable
{
    public class QueueCollection
    {
        public static void Main(string[] args)
        {
            //By using System.Collection.Generic namespace:
            Queue<int>  intCollection = new();

            //And by using System.Collection namespace:
            Queue queueCollection = new Queue();

            //If we declare an object by providing a type (in our example an int), we can store only integer numbers inside. On the other hand, if we use the second example we can store different data types in a collection because it stores objects.

            //Methods and Properties
            queueCollection.Enqueue(54);
            queueCollection.Enqueue("Imane");
            queueCollection.Enqueue(54.01);

            foreach(var item in queueCollection)
            {
                Console.WriteLine(item);
            }

            //When we want to  remove an element at the beginning of the collection and return it, we are going to use the Dequeue method:
            int number = Convert.ToInt32(queueCollection.Dequeue());
            Console.WriteLine($"Removed element is: {number}");
            Console.WriteLine();

            foreach(var item in queueCollection)
            {
                Console.WriteLine(item);
            }

            //The Peek method returns the element at the beginning of the collection but does not remove it:
            Queue queueCollection2 = new Queue();
            queueCollection2.Enqueue(54);
            queueCollection2.Enqueue("John");
            queueCollection2.Enqueue(54.10);

            int peekNumber = Convert.ToInt32(queueCollection2.Peek());
            Console.WriteLine($"Returned element is: {peekNumber}");
            Console.WriteLine();

            //The Clear method removes all the elements from a collection.
            queueCollection.Clear();

            //If we want to check how many elements we have inside a collection, we can use the Count property:
            Console.WriteLine(queueCollection.Count);

        }
    }
}
*/