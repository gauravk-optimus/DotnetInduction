using System;
namespace Advanced_concepts
{

    class Program
    {
        public delegate void gaurav(int value);
        static void Main(string[] args)
        {
            Program p = new Program();
            gaurav g = Sum;
            //gaurav h = Dif;
           // Console.WriteLine(g(5));
            g += Dif;
            //Console.WriteLine(g(5));
            g(5);
            // Console.WriteLine(h(5));
            //Console.ReadLine();

        }
        public static void Sum(int a)
        {
            Console.WriteLine(a+a);
            //return a + a;
        }
        public static void Dif(int a)
        {
            Console.WriteLine(a - a);
            //return a - a;
        }
    }
}