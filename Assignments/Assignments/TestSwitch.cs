using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class TestSwitch
    {
        static void Main(string[] args)
        {
            string PreferredLanguage = "null";
            Console.WriteLine("Enter your preferred Language: ");
            PreferredLanguage = Console.ReadLine();

            switch (PreferredLanguage)
            {
                case "VB":
                    Console.WriteLine("VB .NET: OOP, multithreading and more!");
                    Console.ReadLine();
                    break;
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
