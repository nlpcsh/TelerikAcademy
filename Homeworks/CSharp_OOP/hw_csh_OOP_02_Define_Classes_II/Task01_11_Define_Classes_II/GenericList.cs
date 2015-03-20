
namespace Education_3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class GenericList<T> where T : IComparable
    {
        //const int DefaultCapacity = 4096;
        const int DefaultCapacity = 2;

        private T[] elements;
        private int count = 0;

        public int Length
        {
            get { return this.elements.Length; }
        }

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public GenericList() : this(DefaultCapacity)
        {
        }

        public int Count
        {
            set
            {
                if (count >= elements.Length)
                {
                    this.elements = ResizeArray();
                }
                this.count = value;
            }
            get
            {
                return this.count;
            }
        }

        public void Add(T element)
        {
            if (Count >= elements.Length)
            {
                this.elements = ResizeArray();
            }
            
            this.elements[Count] = element;
            Count++;
            
        }

        public T this[int index]
        {
            set
            {
                this.elements[index] = value;
            }
            get
            {
                if (( index < 0 ) || ( index > Count ))
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public void Remove(int index)
        {
            if ((index < 0) || (index > Count))
            {
                throw new ArgumentException(" Index to remove element of the list is out of range 0 - array.Length! ");
            }

            var lessElements = new T[elements.Length];

            for (int i = 0, j=0; i < elements.Length; i++)
            {
                if (index != i)
                {
                    lessElements[j] = (elements[i]);
                    j++;
                }
            }

            Count--;

            this.elements = lessElements;
        }
 
        public void Incert(int index, T element)
        {
            if ((index < 0) || (index > Count + 1))
            {
                throw new ArgumentException(" Index to remove element of the list is out of range 0 - array.Length! ");
            }
            var incertElements = new T[elements.Length];

            for (int i = 0, j = 0; i <= Count ; i++, j++)
            {
                if (index != i)
                {
                    incertElements[j] = elements[i];
                }
                else
                {
                    incertElements[j] = element;
                    j++;
                    incertElements[j] = elements[i];
                }
            }

            Count++;

            this.elements = incertElements;
            
        }

        public void Clear()
        {
            var cleanElements = new T[DefaultCapacity];

            this.elements = cleanElements ;

            Count = 0;
        }

        public T Min()
        {
            T minValue = elements[0];

            for (int i = 0; i < Count; i++)
            {
                if (minValue.CompareTo(elements[i]) > 0)
                {
                    minValue = elements[i];
                }
            }
            return minValue;
        }

        public T Max()
        {
            T maxValue = elements[0];

            for (int i = 0; i < Count; i++)
            {
                if (maxValue.CompareTo(elements[i]) < 0)
                {
                    maxValue = elements[i];
                }
            }
            return maxValue;
        }

        public override string ToString()
        {
            StringBuilder resultString = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
			{
                resultString.Append(string.Format("Element {0} is {1} \n\r", i, elements[i]));
            }

            return resultString.ToString();
        }

        private T[] ResizeArray()
        {
            var resizedArray = new T[elements.Length * 2];

            for (int i = 0; i < elements.Length; i++)
            {
                resizedArray[i] = elements[i];
            }

            return resizedArray;
        }
    }
}
