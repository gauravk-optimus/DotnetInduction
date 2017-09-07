using System;
namespace Assignments
{
    class TestIf
    {
        static void Main(string[] args)
        {
            string PreferredLanguage = "null";
            Console.WriteLine("Enter your preferred Language: ");
            PreferredLanguage = Console.ReadLine();

            if (PreferredLanguage.Equals("VB"))
            {
                Console.WriteLine("VB .NET: OOP, multithreading and more!");
                Console.ReadLine();
            }
            else if (PreferredLanguage.Equals("C#"))
            {
                Console.WriteLine("Good choice, C# is a fine language.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Well...good luck with that!");
                Console.ReadLine();
            }
        }
    }
}