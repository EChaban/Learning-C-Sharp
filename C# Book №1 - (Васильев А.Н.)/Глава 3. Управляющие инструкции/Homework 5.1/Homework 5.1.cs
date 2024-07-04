/*Напишите программу, в которой пользователю предлагается ввести
название дня недели. По введенному названию программа определяет
порядковый номер дня в неделе. Если пользователь вводит неправильное
название дня, программа выводит сообщение о том, что такого дня
нет. Предложите версию программы на основе вложенных условных
операторов и на основе оператора выбора switch.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите один из параметров:\nmon, tue, wed, thu, fri, sat, sun.");
            string dayOfWeek = Console.ReadLine();
            if (dayOfWeek == "mon") Console.WriteLine("Порядковый номер дня недели: 1");
            else if (dayOfWeek == "tue") Console.WriteLine("Порядковый номер дня недели: 2");
            else if (dayOfWeek == "wed") Console.WriteLine("Порядковый номер дня недели: 3");
            else if (dayOfWeek == "thu") Console.WriteLine("Порядковый номер дня недели: 4");
            else if (dayOfWeek == "fri") Console.WriteLine("Порядковый номер дня недели: 5");
            else if (dayOfWeek == "sat") Console.WriteLine("Порядковый номер дня недели: 6");
            else if (dayOfWeek == "sun") Console.WriteLine("Порядковый номер дня недели: 7");
            else Console.WriteLine("Параметр введён не верно!");
        }
    }
}
