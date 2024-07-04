/*Напишите программу, в которой пользователем вводится два целых числа. 
Программа выводит все целые числа - начиная с наименьшего (из двух введенных чисел) 
и заканчивая наибольшим (из двух введенныхчисел). */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            try
            {
                Console.Write("Введите первое число: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (num1 < num2)
                {
                    while (num1 <= num2)
                    {
                        Console.Write(num1 + " ");
                        num1++;
                    }
                }
                else
                {
                    while (num2 <= num1)
                    {
                        Console.Write(num2 + " ");
                        num2++;
                    }
                }
                Console.WriteLine();
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ошибка! Числа введены не верно!");
                goto start;
            }
        }
    }
}
