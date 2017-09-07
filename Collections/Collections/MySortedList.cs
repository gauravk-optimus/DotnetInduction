using System;
using System.Collections;

namespace Collections
{
    public class MySortedList
    {
        public static void Main(string[] args)
        {
            SortedList sortedList1 = new SortedList();
            sortedList1.Add(1, 2);
            sortedList1.Add(2, 3);
            sortedList1.Add(3, 4);
            sortedList1.Add(4, 1);
            sortedList1.Add(5, 6);

            sortedList1.RemoveAt(0);
            sortedList1.Remove(1);

            Console.WriteLine(sortedList1.Contains(1));
            Console.WriteLine(sortedList1.ContainsKey(2));

            for (int i = 0; i < sortedList1.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", sortedList1.GetKey(i), sortedList1.GetByIndex(i));
            }
            foreach (DictionaryEntry kvp in sortedList1)
            {
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();
        }
    }
}