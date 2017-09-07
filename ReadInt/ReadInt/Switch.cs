using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInt
{
    class Switch
    {
        static void Main(string[] args)
        {
            int number = 1;
            int? dd = null;

            
            switch (number)
            {
                case 0:
                    Console.WriteLine("The number is zero!");
                    break;
                case 1:
                    Console.WriteLine("The number is one!");
                    break;
            }
        }
    }
}