using System;

namespace AccessModifiers
{
    internal class C
    {
        protected int i = 1;
        private int j = 2;
        public int k = 3;
        internal int l = 4;
        protected internal int m = 5;
    }
    class B: C
    {

    }
    class A:C
    {
        static void Main(String [] args)
        {
            C c = new C();
            A a = new A();
            Console.WriteLine(a.i);
            //Console.WriteLine(a.j);
            Console.WriteLine(a.k);
            Console.WriteLine(a.l);
            Console.WriteLine(a.m);

            //Console.WriteLine(c.i);
            //Console.WriteLine(c.j);
            Console.WriteLine(c.k);
            Console.WriteLine(c.l);
            Console.WriteLine(c.m);
        }
    }
}
