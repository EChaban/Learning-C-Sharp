/*Напишите программу, которая проверяет, делится ли введенное пользователем
число на 3.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 3  == 0) Console.WriteLine(num + " делиться на 3.");
            else Console.WriteLine(num + " не делиться на 3.");
            Console.ReadKey();
        }
    }
}
