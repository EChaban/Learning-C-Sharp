/*Напишите программу, которая выводит последовательность чисел
Фибоначчи. Первые два числа в этой последовательности равны 1 , а каждое
следующее число равно сумме двух предыдущих (получается последовательность
1 , 1 , 2 , 3, 5 , 8 , 13 , 21 , 34 , 55 , 89 и так далее). Количество
чисел в последовательности вводится пользователем. Предложите
версии программы, использующие разные операторы цикла.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во чисел Фибоначчи: ");
            int num = int.Parse(Console.ReadLine());
            int lastNum1 = 0, lastNum2 = 1, newNum;

            Console.Write("1 ");
            for (int i = 1; i < num; i++)
            {
                newNum = lastNum1 + lastNum2;
                Console.Write(newNum + " ");
                lastNum1 = lastNum2;
                lastNum2 = newNum;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
