using System;

namespace Assignments
{
    class StringArray
    {
        public static void Main(String[] args)
        {
            StringArray sa = new StringArray();
            sa.GetStringArray();
            Console.ReadLine();
        }
        public void GetStringArray()
        {
            string[] str = new string[] {"Sunday", "Monday", "Tuesday", "Wednessday", "Thursday", "Friday", "Saturday" };
            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("Day is " + str[i]);
            }            
        }
    }
}
