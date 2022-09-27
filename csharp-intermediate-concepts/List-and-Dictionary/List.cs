/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Dictionary
{
    public class List
    {
        public static void Main(string[] args)
        {
            List<int> numbers= new();
            numbers.Add(34);
            numbers.Add(58);
            numbers.Add(69);

            int[] nums = new int[5] {1,2,3,4,5};
            // AddRange adds the elements of the specified collection to the end of a list:
            numbers.AddRange(nums);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //We can check how many elements a list has by using the Count property:
            Console.WriteLine(numbers.Count);

            //Contains determines whether an element exists in the list:
            if (numbers.Contains(34))
            {
                Console.WriteLine("The number 34 exists in a list");
            }

            //The IndexOf method returns the position of an element as an integer number. If an element couldn’t be found, this method returns -1:
            int index;
            if((index = numbers.IndexOf(58)) != -1)
            {
                Console.WriteLine($"The number 58 is on the index: {index}");
            }
            //LastIndexOf is similar to a previous method except it returns a last occurrence of the element.

            //CopyTo method copies the entire collection to a compatible array, starting from the beginning of that array:
            int[] copyArray = new int[10];
            numbers.CopyTo(copyArray);
            foreach(int copyNumber in copyArray)
            {
                Console.WriteLine(copyNumber);
            }

            //The Remove method removes the first occurrence of a specific element from the list:
            numbers.Remove(69);

            //The Clear method clears all the elements from a list:
            numbers.Clear();

            


        }
    }
}
*/