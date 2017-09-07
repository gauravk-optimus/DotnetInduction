using System;

namespace Assignments
{
    class TestEnum
    {
        public static void Main(String[] args)
        {
            int WeekDayStart = (int)WeekDays.Mon;
            int WeekDayEnd = (int)WeekDays.Fri;
            Console.WriteLine(WeekDayStart);
            Console.WriteLine(WeekDayEnd);
            Console.ReadLine();
        }
            enum WeekDays {Mon, Tue, Wed, Thu, Fri, Sat, Sun};
    }
}
