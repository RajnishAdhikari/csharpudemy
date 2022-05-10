using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome1
{
    public abstract class Calc
    {
        // this Calc is abstract class, this abstract class has 2 method  and then defination of calcaddition is defined in another
        //class
        public abstract void calcaddition(int x, int y);
        public void multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
    public class Demos: Calc
    {
        public override void calcaddition(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
    internal class abstract_class
    {
    }
}
