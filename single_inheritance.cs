using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome1
{
    public class Car
    {
        public string model;
        public string color;
        public int price;

        public void PrintCarInformation()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);
        }

        public class Cybertruck : Car
        {
            public int range;
            public void PrintRange()
            {
                Console.WriteLine("Range:" + range);
            }

        }
        internal class single_inheritance
        {
            
        }
    }
}
