/*Напишите программу, которая проверяет, сколько тысяч во введенном
пользователем числе (определяется четвертая цифра справа в десятичном
представлении числа).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int num = int.Parse(Console.ReadLine());
            if (num < 1000) Console.WriteLine("В числе 0 тысяч.");
            else
            {
                num /= 1000;
                Console.WriteLine("В числе " + num % 10 + " тысяч");
            }
        }
    }
}
