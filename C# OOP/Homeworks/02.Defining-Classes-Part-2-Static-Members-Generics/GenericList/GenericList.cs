/* Problem 5. Generic class
 * Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
 * Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
 * Check all input parameters to avoid accessing elements at invalid positions.
 */

/* Problem 6. Auto-grow
 * Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
 */

/* Problem 7. Min and Max
 * Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
 * You may need to add a generic constraints for the type T.
 */

namespace GenericList
{
    using System;
    using System.Linq;
    public class GenericList<T> where T
        : IComparable
    {
        const int DefaultCapacity = 4096;

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public GenericList()
            : this(DefaultCapacity)
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
                AutoGrow();
            }
            this.elements[count] = element;
            count++;
        }

        public T IndexOf(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            return this.elements[index];
        }

        public void RemoveAt(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            this.elements[index] = default(T);
            count--;
        }

        public void Insert(int index, T value)
        {
            if (index >= count)
            {
                AutoGrow();
            }
            int firstPart = index;
            int secondPart = count - index;
            T[] wholeParts = new T[firstPart + secondPart + 1];

            for (int i = 0; i < firstPart; i++)
            {
                wholeParts[i] = this.elements[i];
            }
            wholeParts[index] = value;
            for (int i = 0; i < secondPart; i++)
            {
                wholeParts[index + i + 1] = this.elements[index + i];
            }

            for (int i = 0; i < wholeParts.Length; i++)
            {
                this.elements[i] = wholeParts[i];
            }
            count++;
        }

        public void AutoGrow()   // Problem 6
        {
            T[] tempStore = new T[count * 2];
            for (int i = 0; i < count; i++)
            {
                tempStore[i] = this.elements[i];
            }
            this.elements = tempStore;
        }

        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                this.elements[i] = default(T);
            }
            count = 0;
        }

        public void Find(T value)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    Console.WriteLine("Element with value PHP has index {0}", i);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No such element");
            }
        }

        public T Min()   // Problem 7
        {
            T min = this.elements[0];
            for (int i = 1; i < count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }
        public T Max()   // Problem 7
        {
            T max = this.elements[0];
            for (int i = 1; i < count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public override string ToString()
        {
            return string.Format("Number of elements: {0}", count);
        }
    }
}
