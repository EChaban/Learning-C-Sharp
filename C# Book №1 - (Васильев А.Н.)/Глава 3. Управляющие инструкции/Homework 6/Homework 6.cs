/*Напишите программу, в которой вычисляется сумма нечетных чисел.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во чисел: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0, n = 1; i < num; i++, n += 2)
            {
                sum += n;
            }
            Console.WriteLine("Сумма нечётных чисел: " + sum);
        }
    }
}
