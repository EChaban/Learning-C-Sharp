/*Напишите программу, в которой пользователь последовательно вво-
дит два целых числа. Программа вычисляет остаток от деления больше-
го числа на меньшее число. Программный код следует написать с учетом
обработки возможных ошибок.*/

using System;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Введите второе число: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                int result;

                if (num1 > num2) result = num1 % num2;
                else result = num2 % num1;
                Console.WriteLine($"Остатот от деления = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка " + ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
