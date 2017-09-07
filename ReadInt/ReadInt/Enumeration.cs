using System;

namespace ReadInt
{
    class Enumeration
    {
        enum Days
        {
            Mon, Tue, Wed, Thu, Fri, Sat, Sun
        }
        public static void Main(String []args)
        {
            int WeekdaysStart = (int)Days.Mon;
            int WeekDayEnd = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", + WeekDayEnd);
            Console.WriteLine("Friday: {0}", + WeekdaysStart);
            Console.ReadLine();
        }
    }
}
