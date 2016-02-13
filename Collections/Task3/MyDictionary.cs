using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyDictionary<TKey, TValue> : IEnumerable
    {
        int size = 0;
        private int count = 0;
        private TKey[] keys = null;
        private TValue[] vals = null;

        public int Count
        {
            get { return count; }
        }
        public MyDictionary()
        {

        }
        public void Add(TKey key, TValue val)
        {
            if (size - 1 > count)
            {
                keys[count] = key;
                vals[count] = val;
                count++;
            }
            else
            {
                count++;

                Array.Resize(ref keys, count);
                keys[count - 1] = key;

                Array.Resize(ref vals, count);
                vals[count - 1] = val;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keys.Length; i++)
                {
                    if (key.Equals(keys[i]))
                        ind = i;
                }
                return vals[ind];
            }
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < keys.Length; i++)
                yield return new KeyValuePair<TKey, TValue>(keys[i], vals[i]);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
