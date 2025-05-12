/*Напишите программу, в которой для заданного целочисленного значе-
ния вычисляется факториал, двойной факториал и число из последова-
тельности Фибоначчи. Для вычисления каждого из значений запускается
дочерний поток. Факториал n! для числа n вычисляется как произведе-
ние чисел от 1 до этого числа включительно, то есть n! = 1 × 2 × 3 × ... × n.
Двойной факториал n!! вычисляется как произведение натуральных
чисел «через одно», то есть n!! = n × (n − 2) × (n − 4) × ... (последний
множитель равен 2 или 1 в зависимости от того, четное число n или не-
четное). В последовательности Фибоначчи первые два числа равны 1,
а каждое следующее число равно сумме двух предыдущих (получаются
числа 1, 1, 2, 3, 5, 8, 13, 21 и так далее).*/

using System;
using System.Threading;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Thread fact = new Thread(() =>
            {
                int result = 1;
                for (int i = n; i > 1; i--)
                {
                    result *= i;
                }
                Console.WriteLine($"Факториал числа {n}: {result}");
            });

            Thread fact2 = new Thread(() =>
            {
                int result = 1;
                for (int i = n; i > 1; i -= 2)
                {
                    result *= i;
                }
                Thread.Sleep(500);
                Console.WriteLine($"Двойной факториал числа {n}: {result}");
            });

            Thread feb = new Thread(() =>
            {
                int result = 0;
                int tmp1 = 1, tmp2 = 1;
                for (int i = 1; i < n - 1; i++)
                {
                    result = tmp1 + tmp2;
                    tmp1 = tmp2;
                    tmp2 = result;
                }
                Thread.Sleep(1000);
                Console.WriteLine($"Число фибоначи для {n}: {result}");
            });
            fact.Start();
            fact2.Start();
            feb.Start();
        }
    }
}
