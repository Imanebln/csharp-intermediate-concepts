/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Dictionary
{
    public class Dictionary
    {
        public static void Main(string[] args)
        {
            //Dictionary has several constructors we can use to instantiate objects:

            Dictionary<string, int> dictExample = new Dictionary<string, int>();

            Dictionary<string, int> dictExample1 = new Dictionary<string, int>(5); //to set initial size

            Dictionary<string, int> dictExample2 = new Dictionary<string, int>(dictExample1); //accepts all the elements from created Key-Value collection

            //Methods and Properties
            //The Add method adds the key-value pair inside a collection:
            dictExample.Add("First", 100);
            dictExample.Add("Second", 200);
            dictExample.Add("Third", 300);

            foreach(var item in dictExample)
            {
                Console.WriteLine(dictExample[item.Key]);
            }

            //Remove removes the key-value pair from a collection based on the specified key:
            dictExample.Remove("Second");

            //ContainsKey determines if a collection contains a specific key.
            //ContainsValue determines if a collection contains a specific value:
            if (dictExample.ContainsKey("First"))
            {
                Console.WriteLine("It Contains key");
            }

            if (dictExample.ContainsValue(300))
            {
                Console.WriteLine("It contains value");
            }

            //The Clear method removes all key-value pairs from a collection:
            //dictExample.Clear();

            //If we want to count all of our elements inside a collection, we can use the Count property. If we want to get a collection of containing Keys or containing Values from a dictionary, we can use the Keys and Values properties:
            Console.WriteLine(dictExample.Count);

            foreach(var key in dictExample.Keys)
            {
                Console.WriteLine(key);
            }

            foreach(var value in dictExample.Values)
            {
                Console.WriteLine(value);
            }


        }
    }
}
*/