using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome1
{
    public class Program
    {
        public void calc(int x, int y)   //this is for function overloading 
        {
            Console.WriteLine(x + y);
        }
        public void calc(double x, double y)
        {
            Console.WriteLine(x - y);
        }
    }
    
}

    internal class function_overloading
    {
    }

