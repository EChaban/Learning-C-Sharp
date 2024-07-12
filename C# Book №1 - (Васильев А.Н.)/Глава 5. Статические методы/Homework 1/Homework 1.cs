/*Условие задачи: Напишите прог-му в, которой описан статистический метод для вычисления двойного факториала числа, переданого арг-ом методу.
По определению, двойной факториал числа n(обозночается как n!!) - это произ-е через одно всех чисел, не больших числа n.
То есть n!!= n * (n - 2) * (n - 4) *... (последний множитель равен 1 для нечётного n и равен 2 для чётного.)
Например: 6!! = 6 * 4 * 2 = 48 и 5!! = 5 * 3 * 1 = 15. Предложите версию метода без рекурсии и с рекурсией.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static int Factorial(int n)
        {
            int result = n;
            while (n > 2)
            {
                n -= 2;
                result *= n;
            }
            return result;
        }

        static int FactorialRecursion(int n)
        {
            int result = n;
            if (n <= 2) return result;
            {
                result *= FactorialRecursion(n - 2);
            }
            return result;
        }

        static void Main(string[] args)
        {
            start:
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Двойной факториал числа: " + Factorial(n));

            Console.WriteLine();

            Console.WriteLine("Двойной факториал числа с помощью рекурсии: " + FactorialRecursion(n));
            
            Console.WriteLine();

            goto start;
        }
    }
}
