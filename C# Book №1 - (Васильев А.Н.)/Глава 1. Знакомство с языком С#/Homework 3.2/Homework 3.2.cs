/* Напишите программу, в которой пользователь последовательно вводит
название текущего дня недели, название месяца и дату (номер дня
в месяце). Программа выводит сообщение о сегодняшней дате (день
недели, дата, месяц). Используйте консольный ввод и вывод данных. */

using System;

namespace Homework_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввведите сегодняшний день недели: ");
            string dayOfWeek = Console.ReadLine();
            Console.Write("Ввведите текущий месяц: ");
            string month = Console.ReadLine();
            Console.Write("Ввведите текущий день: ");
            string day = Console.ReadLine();

            Console.WriteLine("Сегодняшняя дата: " + dayOfWeek + " " + day + " " + month);
        }
    }
}
