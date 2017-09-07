using System;
using System.Text;
using ClassLibExtMethod;

namespace ExtensionMethod1
{
    public static class XX
    {
        public static void NewMethod(this Class1 ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ob = new Class1();
            Console.WriteLine(ob.Display());
            Console.WriteLine(ob.Print());
            ob.NewMethod();
            Console.ReadKey();
        }
    }
}