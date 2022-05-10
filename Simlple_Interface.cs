using System;


namespace Welcome1
{
    public interface A
    {
        void m1();
    }
    class B : A
    {
        public void m1()
        {
          Console.WriteLine("M1");
        }
    }
    class C
    {
        //static void Main(string[] args)
        //{
        //    B b = new B();
        //    b.m1();
        //    Console.WriteLine();

        //}
        
    }
    internal class Simlple_Interface
    {
    }
}
