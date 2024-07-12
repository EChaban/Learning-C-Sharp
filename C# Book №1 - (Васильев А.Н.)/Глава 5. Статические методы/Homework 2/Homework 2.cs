/*Напишите программу со статическим методом, которым вычисляется
сумма квадратов натуральных чисел 
Предложите версию метода с рекурсией и без рекурени.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static int SumOfSquares(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += i * i;
            }
            return result;
        }

        static int SumOfSquaresRec(int n)
        {
            if (n == 0) return 0;
            return n * n + SumOfSquaresRec(n - 1);
        }

        static int Verify(int n)
        {
            return n * (n + 1) * (2 * n + 1) / 6;
        }

        static void Main(string[] args)
        {
            start:

            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Сумма n квадратов: " + SumOfSquares(n));

            Console.WriteLine();

            Console.WriteLine("Сумма n квадратов при помощи рекурсии: " + SumOfSquaresRec(n));

            Console.WriteLine();

            Console.WriteLine("Сумма n квадратов (проверочная формула): " + Verify(n));

            goto start;
        }
    }
}
