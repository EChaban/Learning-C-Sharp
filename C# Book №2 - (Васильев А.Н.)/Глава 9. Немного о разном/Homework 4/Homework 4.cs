/*Напишите программу, в которой для указанного интервала времени
(в годах) определяются годы, первый день которых (1 января) попадает
на понедельник.*/

using System;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальный год интервала: ");
            int startYear = int.Parse(Console.ReadLine());
            Console.Write("Введите конечный год интервала: ");
            int endYear = int.Parse(Console.ReadLine());

            Console.WriteLine($"Годы, в которых 1 января - понедельник, в промежутке с {startYear} по {endYear}:");

            for (int year = startYear; year <= endYear; year++)
            {
                DateTime date = new DateTime(year, 1, 1);
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    Console.WriteLine(year);
                }
            }
        }
    }
}
