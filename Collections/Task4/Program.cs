using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>();
            for (int i = 10; i < 20; i++)
            {
                mylist.Add(i);
            }
            IEnumerable<int> massive = mylist.Cast<int>();
            
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist.GetArray()[i]);
                //Console.WriteLine(massive.GetArray<int>()[i]);
            }
            Console.ReadKey();
        }
    }
}
