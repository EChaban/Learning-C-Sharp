/* Напишите программу, в которой вычисляется сумма чисел, удовлетворяющих таким критериям:
при делении числа на 5 в остатке получается 2, или при делении на 3 в остатке получается 1. 
Количество чисел в сумме вводится пользователем. 
Программа отображает числа, которые суммируются, и значение суммы. Используйте обработку исключений. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Homework_I0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Label:
            try
            {
                Console.Write("Введите кол-во суммируюмых чисел: ");
                int amountNums = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = 0, num = 1; i < amountNums; num++)
                {
                    if (num % 5 == 2 || num % 3 == 1)
                    {
                        sum += num;
                        i++;
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Сумма чисел: " + sum);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ошибка! Введено неверное значение!");
                goto Label;
            }
        }
    }
}
