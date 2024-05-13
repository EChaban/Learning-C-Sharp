using System;

namespace TestExtentions
{
    static class MyExtentions
    {
        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            Console.WriteLine(dateTime);
        }
    }
}
