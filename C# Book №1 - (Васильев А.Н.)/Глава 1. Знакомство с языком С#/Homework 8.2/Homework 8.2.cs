/* Напишите программу для вычисления суммы двух чисел. Оба числа
вводятся пользователем. Для вычисления суммы используйте оператор
+ . Предложите два варианта программы: программу, в которой данные
вводятся и выводятся с помощью диалоговых окон, и программу,
в которой используется консольный ввод и вывод данных. */

using System;

namespace Homework_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сложение двух чисел";
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма двух чисел: " + (num1 +num2));
        }
    }
}
