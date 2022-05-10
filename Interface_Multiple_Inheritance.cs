using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome1
{
    // this is the example of multiple interface 
    public interface compute1
    {
        void findsum(int x, int y);
        void finddifference(int x, int y);
    }
    public interface compute2
    {
        void finddivision(int x, int y);
        void findmodulo(int x, int y);
    }

    class practical : compute1, compute2
    {
        public void finddifference(int x, int y)
        {
            Console.WriteLine($"difference: {x - y}");
        }

        public void finddivision(int x, int y)
        {
            Console.WriteLine($"division: {x / y}");
        }

        public void findmodulo(int x, int y)
        {
            Console.WriteLine($"modulo: {x % y}");
        }

        public void findsum(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
        }
    }
    internal class multiple_inheritance
    {
    }
}

