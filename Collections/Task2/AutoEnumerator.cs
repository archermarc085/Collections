using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class AutoEnumerator<T> : IEnumerator
           where T : class,new()
    {
        int currIndex = -1;
        MyList<T> auto = new MyList<T>();
        public AutoEnumerator(MyList<T> auto)
        {
            this.auto = auto;
        }
        public object Current
        {
            get { return auto[currIndex]; }
        }

        public bool MoveNext()
        {
            currIndex++;
            if (currIndex >= auto.Count)
                return false;
            else
                return true;
        }
        public void Reset()
        {
            currIndex = -1;
        }
    }
}
