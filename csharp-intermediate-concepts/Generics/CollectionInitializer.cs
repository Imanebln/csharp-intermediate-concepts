using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CollectionInitializer<T>
    {
        private T[] collection;
        public CollectionInitializer(int collectionLength)
        {
            collection = new T[collectionLength];
        }

        public void AddElementsToCollection(params T[] elements)
        {
            for(int i = 0; i < elements.Length; i++)
            {
                collection[i] = elements[i];
            }
        }

        public T[] RetrieveAllElements()
        {
            return collection;
        }

        public T RetrieveElementOIndex(int index)
        {
            return collection[index];
        }
    }
}
