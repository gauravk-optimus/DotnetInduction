using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class TestStrings
    {
        public static void Main()
        {
            string str1 = "firstString";
            string str3 = "thirdString";
            string str4 = "first";
            string str6 = "Hello C#, How Are You?";
            string str7 = "String";
            string str8 = "String";

            char[] ch = new char[15];
            string str2 = (string)str1.Clone();
            string.Compare(str1, str3);
            string str5 = string.Copy(str1);
            str6.CopyTo(10, ch, 0, 12);
            string str9 = string.Format("{0:D}", DateTime.Now);
            int index = str1.IndexOf('t');
            string str10 = str1.Insert(5, "-");

            Console.WriteLine("Clone() "+ str2);
            Console.WriteLine("Compare() "+string.Compare(str1, str3));
            Console.WriteLine("CompareOrdinal() "+string.CompareOrdinal(str1, str3));
            Console.WriteLine("CompareTo() "+str1.CompareTo(str3));
            Console.WriteLine("Concat() "+string.Concat(str1, str3));
            Console.WriteLine("Contains() "+str1.Contains(str4));            
            Console.WriteLine("Copy() "+str5);
            Console.WriteLine("CopyTo() "+ch);
            Console.WriteLine("EndsWith() "+str1.EndsWith(str7));
            Console.WriteLine("Equals() " + str7.Equals(str8));
            Console.WriteLine("Format() " +str9);
            Console.WriteLine("IndexOf() "+index);
            Console.WriteLine("Insert() "+str10);

            Console.ReadLine();

        }
    }
}