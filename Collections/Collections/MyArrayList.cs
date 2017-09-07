using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;

namespace Collections
{
    public class MyArrayList
    {
        public static void Main(String[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(4);
            list.Add(3);
            list.Add(2);
            list.Add(3);
            list.Add(1);

            ArrayList list2 = new ArrayList();
            list2.AddRange(list);
            list2.Sort();
            list2.Insert(1, 4);
            list2.Remove(3);

            foreach (var v in list)
            {
                Console.WriteLine(v);
            }

            foreach (var w in list2)
            {
                Console.WriteLine(w);
            }
            Console.ReadLine();
        }
    }
}