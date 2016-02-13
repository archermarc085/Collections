using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = { 2, 54, 7, 8, 1002, 33, 124, 54, 6032, 91 };
            foreach (int i in Power(massive))
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            //LINQ
            var evenNumbers = from p in massive
                              where p % 2 == 0
                              select p;
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static IEnumerable<int> Power(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    yield return array[i];
                }
            }
        }
    }
}
