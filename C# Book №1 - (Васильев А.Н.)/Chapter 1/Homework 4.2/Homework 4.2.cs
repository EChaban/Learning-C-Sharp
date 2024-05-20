/* Напишите программу, в которой пользователю предлагается ввести
название месяца и количество дней в этом месяце. Программа выводит
сообщение о том, что соответствующий месяц содержит указанное количество
дней. Предложите версии программы для ввода/вывода данных
через консоль */

using System;

namespace Homework_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Кол-во дней в месяце";
            Console.Write("Введите название месяца: ");
            string month = Console.ReadLine();
            Console.Write("Введите кол-во дней в этом месяце: ");
            string amountOfDays = Console.ReadLine();
            Console.WriteLine("В месяце " + month + " " + amountOfDays + " дней");
        }
    }
}
