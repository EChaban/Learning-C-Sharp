/*Напишите программу, которая проверяет, удовлетворяет ли введенное
пользователем число следующим критериям: число делится на 4,
и при этом оно не меньше 10 .*/

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
            Console.Write("Введите число:");
            int num = int.Parse(Console.ReadLine());
            if (num % 4 == 0 && num > 10) Console.WriteLine("Соответсвует: число делится на 4, и при этом оно не меньше 10.");
            else Console.WriteLine("Не соответствует: Соответсвует: число делится на 4, и при этом оно не меньше 10..");
        }
    }
}
