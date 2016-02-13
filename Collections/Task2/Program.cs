using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            MyList<Auto> myauto = new MyList<Auto>();
            myauto.Add(auto);
            myauto[0].Name = "Audi";
            myauto.Add(new Auto());

            foreach (Auto item in myauto)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(myauto.Count);
            Console.ReadLine();
        }
    }
}
