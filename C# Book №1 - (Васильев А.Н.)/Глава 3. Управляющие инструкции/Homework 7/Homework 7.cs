/*Напишите программу для вычисления суммы квадратов натуральных чисел.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во чисел: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, i = 0;
            do
            {
                i++;
                sum += (i * i);
            } while (i < n);
            Console.WriteLine("Суммы квадратов натуральных чисел: " + sum);
            Console.WriteLine("Проверка: " + n*(n+1)*(2*n+1)/6);
        }
    }
}
