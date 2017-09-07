using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class D:C
    {
        static void Main(String[] args)
        {
            C e = new C();
            D d = new D();
            Console.WriteLine(d.i);
            //Console.WriteLine(d.j);
            Console.WriteLine(d.k);
            Console.WriteLine(d.l);
            Console.WriteLine(d.m);

            //Console.WriteLine(e.i);
            //Console.WriteLine(e.j);
            Console.WriteLine(e.k);
            Console.WriteLine(e.l);
            Console.WriteLine(e.m);
        }


    }
}
