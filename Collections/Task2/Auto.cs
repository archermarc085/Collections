using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Auto
    {
        MyList<Auto> auto = new MyList<Auto>();
        public int Speed { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public Auto(string name, int speed, int price)
        {
            Name = name;
            Speed = speed;
            Price = price;
        }
        public Auto()
            : this("BMW", 230, 40000)
        {

        }
        public void Show()
        {
            Console.WriteLine(@"Name: {0}
Speed: {1} 
Price: {2}", Name, Speed, Price);
        }
        public Auto this[int index]
        {
            get { return (Auto)auto[index]; }
        }
        public int GetNumberOfCars()
        {
            return auto.Count;
        }
    }
}
