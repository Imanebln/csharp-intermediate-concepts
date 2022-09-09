using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_Hashtable
{
    public class HashtableCollection
    {
        public enum Element
        {
            First,
            Second,
            Third
        }
        public static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();

            // Methods and Properties
            // The Add method adds an element with the specified key and value into the collection:
            hashTable.Add(Element.First, 174);
            hashTable.Add(Element.Second, "Sixty");
            hashTable.Add(Element.Third, 124.24);

            foreach(var key in hashTable.Keys)
            {
                Console.WriteLine($"Key: {key}, value: {hashTable[key]}");
            }

            // The Remove method removes the element with the specified key from a collection:
            hashTable.Remove(Element.Second);
            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine($"Key: {key}, value: {hashTable[key]}");
            }

            // ContainsKey  determines whether a collection contains a specific key:
            if (hashTable.ContainsKey(Element.Second))
            {
                Console.WriteLine($"Collection contains key: {Element.Second} and value: {hashTable[Element.Second]}");
            }
            // The ContainsValue method determines whether a collection contains a specific value.

            // Clear removes all elements from a collection:
            hashTable.Clear();

            // Count property counts the number of elements inside a collection:
            Console.WriteLine(hashTable.Count);

            // Keys property returns all the keys from a collection and the Value property returns all the values from a collection:
            foreach(var key in hashTable.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();
            foreach(var value in hashTable.Values)
            {
                Console.WriteLine(value);
            }

        }



    }
}
