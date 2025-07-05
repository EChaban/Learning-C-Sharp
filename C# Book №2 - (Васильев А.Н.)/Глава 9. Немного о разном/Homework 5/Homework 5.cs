/*Напишите программу, содержащую статический метод, которому пе-
редаются два аргумента, определяющих некоторые даты. Метод сравни-
вает эти даты на предмет совпадения. Даты считаются совпадающими,
если они отличаются не более чем на определенный интервал времени.
Интервал времени задается третьим аргументом метода.*/

using System;

namespace Homework_5
{
    internal class Program
    {
        static void CompareDates(DateTime firstDate, DateTime secondDate, TimeSpan interval)
        {
            TimeSpan tmpInterval = (firstDate > secondDate) ? firstDate - secondDate : secondDate - firstDate;
            if (tmpInterval <= interval)
                Console.WriteLine("Даты равны");
            else Console.WriteLine("Даты не равны");
        }
        

        static void Main(string[] args)
        {
            DateTime first = new DateTime(2000,12,30);
            DateTime second = new DateTime(2000, 9, 21);
            TimeSpan interval = new TimeSpan(100, 0, 0, 0);
            CompareDates(first, second, interval);
        }
    }
}
