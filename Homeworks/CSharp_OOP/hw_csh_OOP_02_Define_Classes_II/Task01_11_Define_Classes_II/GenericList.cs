using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_3D
{
    class GenericList<T>
    {
        const int DefaultCapacity = 4096;

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public GenericList() : this(DefaultCapacity)
        {
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format("The list capacity of {0} was exceeded.", elements.Length));
            }
            this.elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public void Remove(int index)
        {
            this.elements.ToList().RemoveAt(index);
        }
 
        public void Incert(int index, T element)
        {
            this.elements.ToList().Insert(index, element);
        }

        public void ClearT()
        {
            this.elements.ToList().Clear();
        }

        public override string ToString()
        {
            StringBuilder resultString = new StringBuilder();

            for (int i = 0; i < this.elements.ToList().Count; i++)
			{
                resultString.Append( string.Format("Element {0} is {1}", i, elements));
            }

            return resultString.ToString();
        }
    }
}
