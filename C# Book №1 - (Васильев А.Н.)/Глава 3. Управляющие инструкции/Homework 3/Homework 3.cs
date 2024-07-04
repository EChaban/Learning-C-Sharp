/*Напишите программу, в которой вычисляется сумма чисел, которые
вводит пользователь. Программа выводит запрос на ввод числа, считывает
введенное пользователем число, прибавляет его к сумме и снова
выводит запрос на ввод числа. Процесс продолжается до тех пор, пока
пользователь не введет нулевое значение. Используйте обработку исключений.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            try
            {
                int sum = 0, num;
                while (true)
                {
                    Console.Write("Введите число: ");
                    num = int.Parse(Console.ReadLine());
                    if (num > 0)
                    {
                        sum += num;
                        Console.WriteLine("Сумма всех введёных чисел = " + sum);
                    }
                    else break;
                }
            }

            catch
            {
                Console.WriteLine("Число было введино не верно!");
                goto start;
            }
        }
    }
}
