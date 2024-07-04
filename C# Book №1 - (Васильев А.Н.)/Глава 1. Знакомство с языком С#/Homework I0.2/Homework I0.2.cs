/* Напишите программу, в которой пользователь вводит два числа, а программой
вычисляется и отображается сумма и разность этих чисел. Предложите
варианты программы с использованием консольного ввода/вывода
данных и ввода и вывода данных с помощью диалоговых окон. */

using System;

namespace Homework_I0._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Разность чисел";
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите воторое число: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Разность чисел: " + (num1 - num2));
        }
    }
}
