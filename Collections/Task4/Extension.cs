using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    static class Extension
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            int count = 0; 
            T[] array = new T[count];
            foreach (T val in list)
            {
                T[] newMassive = new T[array.Length + 1];
                array.CopyTo(newMassive, 0);
                newMassive[array.Length] = val;
                array = newMassive;
            }
            return array;
        }
    }
}
