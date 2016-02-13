using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyList<T> : IEnumerable<T>
    {
        T[] array;
        int size = 0;
        int count = 0;
        public int Count { get { return count; } }
        public T this[int index]
        {
            get { return (T)array[index]; }
        }
        public MyList()
            : this(2)
        {
        }
        public MyList(int capacity)
        {
            size = capacity;
            array = new T[capacity];
        }
        public T Get(int index)
        {
            return array[index];
        }
        public void Add(T obj)
        {
            if (size - 1 > count)
            {
                array[count] = obj;
                count++;
            }
            else
            {
                size++;
                Array.Resize<T>(ref array, size);
                array[count] = obj;
                count++;
            }
        }
        public void Remove(int index)
        {
            array[index] = default(T);
            count--;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
                yield return item;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
