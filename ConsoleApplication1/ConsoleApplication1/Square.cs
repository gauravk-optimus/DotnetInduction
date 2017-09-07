using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class ShapesClass
    {
        abstract public int Area();
        //abstract int Area();
    }
    class Square : ShapesClass , interf
    {
        public override int Area()
        {
            Console.WriteLine("test");
            Console.ReadLine();
            return 1;
        }

        public void A()
        {

        }

        static void Main()
        {
            Square sq = new Square();
            sq.Area();
        }

        
    }
    public interface interf
    {
          void A();

    }
}
