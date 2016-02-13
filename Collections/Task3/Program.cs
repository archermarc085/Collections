using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, Auto> auto = new MyDictionary<string, Auto>();
            Auto car = new Auto();
            auto.Add("Audi", car);
            auto.Add("BMW", car);
            foreach (var s in auto)
            {
                Console.WriteLine(s.Key);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
